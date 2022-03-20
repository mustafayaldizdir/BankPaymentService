using BankPaymentService.Application.Interfaces;
using BankPaymentService.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private CcBinCodeRepository _ccBinCodeRepository;
        private PaymentInfoRepository _paymentInfoRepository;

        public ICcBinCodeRepository CcBinCodes => _ccBinCodeRepository = _ccBinCodeRepository ??
            new CcBinCodeRepository(_context);
        public IPaymentInfoRepository PaymentInfos => _paymentInfoRepository = _paymentInfoRepository ??
            new PaymentInfoRepository(_context);
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
