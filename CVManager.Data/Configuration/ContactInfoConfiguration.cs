using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    public class ContactInfoConfiguration : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.ToTable("Contact_Info");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(i => i.Time).IsRequired();
            builder.Property(i => i.Address).IsRequired();
            builder.Property(i => i.createDate).ValueGeneratedOnAdd();
        }
    }
}
