using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Domain.Entities;

namespace BankPaymentService.Persistence.Services.BankServices
{
    public class AktifYatirimBankService : PaymentProvider
    {
        public AktifYatirimBankService(IPaymentService paymentService) : base(paymentService) { }

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
