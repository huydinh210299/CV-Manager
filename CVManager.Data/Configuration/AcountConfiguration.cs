using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    public class AcountConfiguration : IEntityTypeConfiguration<Acount>
    {
        public void Configure(EntityTypeBuilder<Acount> builder)
        {
            builder.ToTable("Acount");
            builder.HasKey(u => u.ID);
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.ObjectId).IsRequired();
            builder.Property(u => u.ObjectRole).IsRequired().HasDefaultValue("ROLE_USER");
        }
    }
}
