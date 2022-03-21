using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Domain.Entities;
using BankPaymentService.Infrastructure.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Interfaces
{
    public interface IBankFactory
    {
        IPaymentProvider Create(PaymentInfoDto paymentInfoDto);

    }
}
