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
    public  class BinCodeService : IBinCodeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BinCodeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<CcBinCode>> CreateAsync(CcBinCode entity)
        {
            await _unitOfWork.CcBinCodes.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return Response<CcBinCode>.Success(entity, 200);
        }

        public async Task<Response<IEnumerable<CcBinCode>>> GetAllAsync()
        {
            var result = await _unitOfWork.CcBinCodes.GetAllAsync();
            return Response<IEnumerable<CcBinCode>>.Success(result, 200);
        }
    }
}
