using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Interfaces.Services
{
    public  interface IPaymentService
    {
        Task<Response<PaymentInfoDto>> CreateAsync(PaymentInfoDto entity);
        Task<Response<IEnumerable<PaymentInfo>>> GetAllAsync();
    }
}
