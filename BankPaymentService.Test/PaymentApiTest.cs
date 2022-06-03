using AutoMapper;
using BankPaymentService.API.Controllers;
using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Application.Profiles;
using BankPaymentService.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankPaymentService.Test
{
    public class PaymentApiTest
    {
        private readonly Mock<IBankFactory> _mockBankFactory;
        private readonly Mock<IPaymentService> _mockPaymentService;
        private readonly Mock<IRedisService>_redisService;
        private readonly AutoMapper.IMapper _mockMapper; 
        private readonly PaymentController _controller;

        private List<PaymentTransaction> _paymentTransactions;

        public PaymentApiTest()
        {
            _mockPaymentService = new Mock<IPaymentService>();
            _mockBankFactory = new Mock<IBankFactory>();
            _redisService = new Mock<IRedisService>();
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PaymentInfoProfile());
            });
           _mockMapper= mockMapper.CreateMapper();
            _controller = new PaymentController(_mockPaymentService.Object,_mockBankFactory.Object, _mockMapper, _redisService.Object);

            _paymentTransactions = new List<PaymentTransaction>()
            {
                new PaymentTransaction{ Name = "Ahmet Yılmaz",CardNumber = "5549603322214444", BankId = 1,BankName = "Ziraat Bankası", Cvv = 333,ExpirationDate = "12/22",CreatedDate = DateTime.UtcNow },
                new PaymentTransaction{ Name = "Ahmet Hamdi",CardNumber = "5549603323214444", BankId = 1,BankName = "Ziraat Bankası", Cvv = 333,ExpirationDate = "12/22",CreatedDate = DateTime.UtcNow },
                new PaymentTransaction{ Name = "Tufan Yılmaz",CardNumber = "5549603452214444", BankId = 1,BankName = "Ziraat Bankası", Cvv = 333,ExpirationDate = "12/22",CreatedDate = DateTime.UtcNow },
                new PaymentTransaction{ Name = "Ayşe Yılmaz",CardNumber = "5549603214444", BankId = 1,BankName = "Ziraat Bankası", Cvv = 333,ExpirationDate = "12/22",CreatedDate = DateTime.UtcNow },
                new PaymentTransaction{ Name = "Ahmet Dede",CardNumber = "5549603322214444", BankId = 1,BankName = "Ziraat Bankası", Cvv = 333,ExpirationDate = "12/22",CreatedDate = DateTime.UtcNow },
                new PaymentTransaction{ Name = "Mustafa Türkyılmaz",CardNumber = "5549603322514444", BankId = 1,BankName = "Ziraat Bankası", Cvv = 333,ExpirationDate = "12/22",CreatedDate = DateTime.UtcNow }
            };

        }

        [Fact]
        public async void GetPaymentTransaction_ActionExecutes_ReturnOkResultWithPaymentTransaction()
        {
            _mockPaymentService.Setup(x => x.GetAllTransactionAsync()).ReturnsAsync(Response<List<PaymentTransaction>>.Success(_paymentTransactions,200));

            var result = await _controller.GetPaymentTransactions();

            var okResult = Assert.IsType<ObjectResult>(result);

            var returnPaymentTransactions = Assert.IsType<Response<List<PaymentTransaction>>>(okResult.Value);

            Assert.Equal<int>(6, returnPaymentTransactions.Data.Count);

        }

        [Fact]
        public async void Payment_ActionExecutes_ReturnCreateAction()
        {
            var paymentInfoDto = new Application.Dto.PaymentInfo.PaymentInfoDto() { Name = "Mustafa Yaldızdır", CardNumber = "5544332211110099", BankId = 1, Cvv = 333, CreatedDate = DateTime.UtcNow, ExpirationDate = "11/24"};
            var paymentInfoInput = new Application.Dto.PaymentInfo.PaymentInfoInput() { Name = "Mustafa Yaldızdır", CardNumber = "5544332211110099",  Cvv = 333, ExpirationDate = "11/24" };

            _mockPaymentService.Setup(x => x.CreateAsync(paymentInfoDto))
                .ReturnsAsync(Response<PaymentInfo>.Success(_mockMapper.Map<PaymentInfo>(paymentInfoDto), 200));
            
            var result = await _controller.Create(paymentInfoInput);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);

            _mockPaymentService.Verify(x => x.CreateAsync(paymentInfoDto), Times.Once);

            Assert.Equal("Create", createdAtActionResult.ActionName);
        }
    }
}
