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
            builder.Property(u => u.ID).HasDefaultValue(Guid.NewGuid());
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.ObjectRole).IsRequired().HasDefaultValue("ROLE_USER");
            builder.Property(u => u.createDate).HasDefaultValue(DateTime.Now);

            builder.HasOne(a => a.User)
                .WithOne(u => u.Acount)
                .HasForeignKey<User>(u => u.ID_Acount);

            builder.HasOne(a => a.Enterprise)
                .WithOne(e => e.Acount)
                .HasForeignKey<Enterprise>(e => e.ID_Acount);
        }
    }
}
