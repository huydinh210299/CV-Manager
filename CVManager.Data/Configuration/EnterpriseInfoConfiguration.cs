using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    public class EnterpriseInfoConfiguration : IEntityTypeConfiguration<EnterpriseInfo>
    {
        public void Configure(EntityTypeBuilder<EnterpriseInfo> builder)
        {
            builder.ToTable("Enterprise_Info");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).HasDefaultValue(Guid.NewGuid());
            builder.Property(i => i.Company_Name).IsRequired();
            builder.Property(i => i.Tax_Code).IsRequired();
            builder.Property(i => i.Area).IsRequired();
            builder.Property(i => i.Phone).IsRequired();
            builder.Property(i => i.Email).IsRequired();
            builder.Property(i => i.Website).IsRequired();
            builder.Property(i => i.Scale).IsRequired();
            builder.Property(i => i.createDate).HasDefaultValue(DateTime.Now);
        }
    }
}
