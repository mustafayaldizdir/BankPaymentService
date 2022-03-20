using BankPaymentService.Application.ControllerBases;
using BankPaymentService.Application.Dto.PaymentInfo;
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

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentTransactions()
        {
            var payments = await _paymentService.GetAllAsync();
            return Ok(payments);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentInfoDto paymentInfoDto)
        {
            var response = await _paymentService.CreateAsync(paymentInfoDto);
            return CreateActionResultInstance(response);
        }
    }
}
