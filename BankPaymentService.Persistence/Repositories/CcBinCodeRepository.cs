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
    public class CcBinCodeRepository : Repository<CcBinCode>, ICcBinCodeRepository
    {
        public CcBinCodeRepository(DbContext context) : base(context)
        {
        }
    }
}
