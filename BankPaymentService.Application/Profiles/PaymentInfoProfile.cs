using AutoMapper;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Profiles
{
    public class PaymentInfoProfile : Profile
    {
        public PaymentInfoProfile()
        {
            CreateMap<PaymentInfo, PaymentInfoDto>().ReverseMap();
        }
    }
}
