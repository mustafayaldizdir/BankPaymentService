using BankPaymentService.Application.Dto;
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
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CcBinCodeRepository(DbContext context) : base(context)
        {
        }
        public async Task<CcBinCode> GetBankData(string cardFirstSixNumber)
        {
            var result = _appDbContext.Set<CcBinCode>().Where(x => x.BinCode == cardFirstSixNumber);

            return result != null ? result.ToList()[0] : new CcBinCode();
        }
    }
}
