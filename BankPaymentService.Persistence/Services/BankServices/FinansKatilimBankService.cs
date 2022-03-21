using BankPaymentService.Application.Dto;
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
    public class FinansKatilimBankService : PaymentProvider
    {
        public FinansKatilimBankService(IPaymentService paymentService) : base(paymentService) { }

        /// <summary>
        /// If bank payment transaction has a custom payment development configuration 
        /// </summary>
        /// <param name="paymentInfoDto"></param>
        /// <returns></returns>
        public override async Task<Response<PaymentInfo>> BankPayment(PaymentInfoDto paymentInfoDto)
        {
            return await paymentService.CreateAsync(paymentInfoDto);
        }

    }
}
