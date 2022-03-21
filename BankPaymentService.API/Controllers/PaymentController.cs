using AutoMapper;
using BankPaymentService.Application.ControllerBases;
using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Repositories;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Application.Validators;
using BankPaymentService.Domain.Entities;
using BankPaymentService.Infrastructure.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankPaymentService.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : CustomControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IBankFactory _bankFactory;
        private readonly IMapper _mapper;

        public PaymentController(
            IPaymentService paymentService,
            IBankFactory bankFactory, 
            IMapper mapper)
        {
            _paymentService = paymentService;
            _bankFactory = bankFactory;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentTransactions()
        {
            var payments = await _paymentService.GetAllTransactionAsync();
            return CreateActionResultInstance(payments);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentInfoInput paymentInfoInput)
        {
            var paymentInfoValidator = new PaymentInfoValidator();
            var validationResult = paymentInfoValidator.Validate(paymentInfoInput);

            if (validationResult.IsValid)
            {
                var paymentInfoDto = _mapper.Map<PaymentInfoDto>(paymentInfoInput);
                var paymentProvider = _bankFactory.Create(paymentInfoDto);
                var response = await paymentProvider.BankPayment(paymentInfoDto);
                return CreateActionResultInstance(response);
            }
            else
            {
                return BadRequest(Response<NoContent>.Fail(validationResult.Errors.First().ErrorMessage, 404));
            }
        }
    }
}
