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
using StackExchange.Redis;

namespace BankPaymentService.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : CustomControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IBankFactory _bankFactory;
        private readonly IMapper _mapper;
        private readonly IRedisService _redisService;
        private readonly IDatabase _db;

        public PaymentController(
            IPaymentService paymentService,
            IBankFactory bankFactory,
            IMapper mapper, IRedisService redisService)
        {
            _paymentService = paymentService;
            _bankFactory = bankFactory;
            _mapper = mapper;
            _redisService = redisService;
            _db = _redisService.GetDb(0);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentTransactions()
        {
            var payments = await _paymentService.GetAllTransactionAsync();
            _redisService.Connect();
            _db.StringSet("email", "yaldizdir@gmail.com");
            _db.StringSet("ziyaretci", 100);
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
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var value =  _db.StringGet("email");
            if (value.HasValue)
            {
                return Ok(value.ToString());
            }
            else
            {
                return Ok("yok");
            }
        }
    }
}
