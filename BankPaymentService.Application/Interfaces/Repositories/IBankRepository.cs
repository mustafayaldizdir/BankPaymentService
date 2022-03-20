using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Interfaces.Repositories
{
    public interface IBankRepository : IRepository<Bank>
    {
    }
}
