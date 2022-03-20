using BankPaymentService.Application.Dto;
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
        Task<Response<PaymentInfo>> CreateAsync(PaymentInfo entity);
        Task<Response<IEnumerable<PaymentInfo>>> GetAllAsync();
    }
}
