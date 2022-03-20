using BankPaymentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Configurations
{
    public class CcBinCodeConfiguration : IEntityTypeConfiguration<CcBinCode>
    {
        public void Configure(EntityTypeBuilder<CcBinCode> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.BinCode).IsRequired().HasMaxLength(6);
            builder.Property(p => p.CardType).IsRequired().HasMaxLength(10);
            builder.Property(p => p.BankCode).IsRequired();
            builder.Property(p => p.BankName).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Organization).IsRequired().HasMaxLength(100);
            builder.Property(p => p.IsCommercialCard).IsRequired();
            builder.Property(p => p.IsSupportInstallment).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            builder.ToTable("CcBinCodes");

        }

        
    }
}
