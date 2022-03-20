using BankPaymentService.Application.Interfaces;
using BankPaymentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Repositories
{
    public class PaymentInfoRepository : Repository<PaymentInfo>, IPaymentInfoRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public PaymentInfoRepository(DbContext context) : base(context)
        {
        }
    }
}
