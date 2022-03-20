using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Services.BankServices
{
    public class AkbankService : IPaymentProvider
    {
        private readonly ICcBinCodeRepository _ccBinCodeRepository;

        public AkbankService(ICcBinCodeRepository ccBinCodeRepository)
        {
            _ccBinCodeRepository = ccBinCodeRepository;
        }

        public async Task<Response<CcBinCode>> BankPayment(int cardfirstSixNumber)
        {
            var result = await _ccBinCodeRepository.GetBankData(cardfirstSixNumber);
            return Response<CcBinCode>.Success(result, 200);
        }
    }
}
