using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Domain.Entities;
using System.Text;

namespace BankPaymentService.Application.Interfaces
{
    public abstract class PaymentProvider : IPaymentProvider
    {
        public readonly IPaymentService paymentService;

        public  PaymentProvider(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public virtual async Task<Response<PaymentInfo>> BankPayment(PaymentInfoDto paymentInfoDto)
        {
           return await  paymentService.CreateAsync(paymentInfoDto);
        } 
    }
}
