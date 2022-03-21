﻿using AutoMapper;
using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Repositories
{
    public class PaymentInfoRepository : Repository<PaymentInfo>, IPaymentInfoRepository
    {
        private readonly IMapper _mapper;
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public PaymentInfoRepository(DbContext context) : base(context)
        {
        }

        public async Task<List<PaymentInfo>> GetPaymentTransactionsAsync()
        {
            return await _appDbContext.Set<PaymentInfo>().Include(x => x.Bank).ToListAsync();
        }
    }
}
