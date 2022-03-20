using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<PaymentInfo>> CreateAsync(PaymentInfo entity)
        {
            await _unitOfWork.PaymentInfos.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return Response<PaymentInfo>.Success(entity, 200);
        }

        public async Task<Response<IEnumerable<PaymentInfo>>> GetAllAsync()
        {
            var result = await _unitOfWork.PaymentInfos.GetAllAsync();
            return Response<IEnumerable<PaymentInfo>>.Success(result, 200);
        }

    }
}
