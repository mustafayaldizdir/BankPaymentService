using BankPaymentService.Application.Dto;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Interfaces
{
    public interface IPaymentInfoRepository : IRepository<PaymentInfo>
    {
        public Task<List<PaymentInfo>> GetPaymentTransactionsAsync();
    }
}
