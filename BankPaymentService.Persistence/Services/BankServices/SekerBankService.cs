using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Services.BankServices
{
    public class SekerBankService : IPaymentProvider
    {
        public Task<Response<NoContent>> BankPayment(string cardfirstSixNumber)
        {
            throw new NotImplementedException();
        }
    }
}
