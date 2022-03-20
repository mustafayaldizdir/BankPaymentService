using BankPaymentService.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Validators
{
    public class PaymentInfoValidator : AbstractValidator<PaymentInfo>
    {
        public PaymentInfoValidator()
        {
            RuleFor(x => x.CardNumber)
                .NotEmpty()
                .Length(16, 16)
                .Custom((cardNumber, context) =>
                {
                    int number;
                    bool result = int.TryParse(cardNumber, out number);
                    if (!result)
                    {
                        context.AddFailure("Invalid credit card number format.");
                    }
                });
        }
    }
}
