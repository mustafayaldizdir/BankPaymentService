using BankPaymentService.Application.Dto;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Interfaces.Services
{
    public interface IBinCodeService
    {
        Task<Response<CcBinCode>> CreateAsync(CcBinCode entity);
        Task<Response<IEnumerable<CcBinCode>>> GetAllAsync();
    }
}
