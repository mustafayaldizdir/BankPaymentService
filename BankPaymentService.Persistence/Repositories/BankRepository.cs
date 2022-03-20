using BankPaymentService.Application.Interfaces.Repositories;
using BankPaymentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Repositories
{
    public class BankRepository : Repository<Bank>, IBankRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public BankRepository(DbContext context) : base(context)
        {
        }
    }
}
