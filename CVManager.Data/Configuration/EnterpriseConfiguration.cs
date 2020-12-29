using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    class EnterpriseConfiguration : IEntityTypeConfiguration<Enterprise>
    {
        public void Configure(EntityTypeBuilder<Enterprise> builder)
        {
            builder.ToTable("Enterprise");
            builder.HasKey(e => e.ID);
            builder.Property(e => e.ID).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Phone).IsRequired();
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.Gender).IsRequired();
            builder.Property(e => e.Position).IsRequired();
            builder.Property(e => e.ID_Acount).IsRequired();
            builder.Property(e => e.createDate).ValueGeneratedOnAdd();

            builder.HasOne(e => e.EnterpriseInfo)
                .WithOne(i => i.Enterprise)
                .HasForeignKey<EnterpriseInfo>(i => i.ID_Enterprise);

            builder.HasMany(e => e.Posts)
                .WithOne(p => p.Enterprise);

        }
    }
}
