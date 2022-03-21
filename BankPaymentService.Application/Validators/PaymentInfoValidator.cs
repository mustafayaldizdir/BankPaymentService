using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Validators
{
    public class PaymentInfoValidator : AbstractValidator<PaymentInfoInput>
    {
        public PaymentInfoValidator()
        {
            RuleFor(x => x.CardNumber)
                .NotEmpty()
                .Length(16, 16)
                .Custom((cardNumber, context) =>
                {
                    long number;
                    bool result = long.TryParse(cardNumber, out number);
                    if (!result)
                    {
                        context.AddFailure("Invalid credit card number format.");
                    }
                });
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Kart sahibi adı alanı boş olamaz.");
            RuleFor(x => x.Cvv).GreaterThan(100).LessThanOrEqualTo(999).WithMessage("CVV alanını lütfen 3 hane olarak giriniz.");
            RuleFor(x => x.ExpirationDate).Length(5, 5).NotEmpty().NotNull().WithMessage("dd/yy formatında giriş yapmalısınız.");
        }
    }
}
