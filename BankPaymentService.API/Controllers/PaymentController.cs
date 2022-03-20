using BankPaymentService.Application.ControllerBases;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Domain.Entities;
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

        public PaymentController(IPaymentService paymentService, IBankFactory bankFactory)
        {
            _paymentService = paymentService;
            _bankFactory = bankFactory;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentTransactions()
        {
            var payments = await _paymentService.GetAllAsync();
            return CreateActionResultInstance(payments);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentInfoDto paymentInfoDto)
        {
            var response = await _bankFactory.Payment(paymentInfoDto);
            return CreateActionResultInstance(response);
        }
    }
}
