using AutoMapper;
using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
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

        private readonly IMapper _mapper;

        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<PaymentInfoDto>> CreateAsync(PaymentInfoDto paymentInfoDto)
        {
            var entity =  _mapper.Map<PaymentInfo>(paymentInfoDto);
            await _unitOfWork.PaymentInfos.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return Response<PaymentInfoDto>.Success(_mapper.Map<PaymentInfoDto>(entity), 200);
        }

        public async Task<Response<IEnumerable<PaymentInfo>>> GetAllAsync()
        {
            var result = await _unitOfWork.PaymentInfos.GetAllAsync();
            return Response<IEnumerable<PaymentInfo>>.Success(result, 200);
        }

    }
}
