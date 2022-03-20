using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Repositories;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Factory
{
    public class PaymentProviderFactory 
    {
        private readonly IBankRepository _bankRepository;
        private readonly ICcBinCodeRepository _ccBinCodeRepository;

        public PaymentProviderFactory(IBankRepository bankRepository, ICcBinCodeRepository ccBinCodeRepository)
        {
            _bankRepository = bankRepository;
            _ccBinCodeRepository = ccBinCodeRepository;
        }

        //public Task<Response<CcBinCode>> BankPayment(PaymentInfo paymentInfo)
        //{
        //    //var bankCode = _ccBinCodeRepository.GetBankData()
        //    var bank = _bankRepository.GetByIdAsync(paymentInfo.BankId);


        //}
    }
}
