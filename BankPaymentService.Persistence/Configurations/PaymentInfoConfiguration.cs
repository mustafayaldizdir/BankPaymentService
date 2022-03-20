using BankPaymentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Configurations
{
    public class PaymentInfoConfiguration : IEntityTypeConfiguration<PaymentInfo>
    {
        public void Configure(EntityTypeBuilder<PaymentInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
            builder.Property(p => p.CardNumber).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Cvv).IsRequired();
            builder.Property(p => p.ExpirationDate).IsRequired();
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.ToTable("PaymentInfos");
        }
    }
}
