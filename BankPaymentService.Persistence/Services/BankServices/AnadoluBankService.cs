﻿using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Services.BankServices
{
    public class AnadoluBankService : IPaymentProvider
    {
        private readonly IPaymentService _paymentService;

        public AnadoluBankService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public async Task<Response<PaymentInfo>> BankPayment(PaymentInfoDto paymentInfoDto)
        {
            var result = await _paymentService.CreateAsync(paymentInfoDto);
            return result;

        }
    }
}
