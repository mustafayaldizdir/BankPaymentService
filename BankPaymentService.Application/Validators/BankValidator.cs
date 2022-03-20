using BankPaymentService.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Validators
{
    public  class BankValidator : AbstractValidator<Bank>
    {
        public BankValidator()
        {
            RuleFor(bank => bank.BankCode).NotNull().NotEmpty();
            RuleFor(bank => bank.Name).NotNull().NotEmpty();
        }
    }
}
