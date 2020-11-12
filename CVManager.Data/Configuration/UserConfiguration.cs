using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.ID);
            builder.Property(u => u.ID).HasDefaultValue(Guid.NewGuid());
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.School).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Phone).IsRequired();
            builder.Property(u => u.ID_Acount).IsRequired();
            builder.Property(u => u.Status).HasDefaultValue(true);
            builder.Property(u => u.createDate).HasDefaultValue(DateTime.Now);

            builder.HasMany(u => u.CVs)
                .WithOne(c => c.User);

            builder.HasMany(u => u.Contacts)
                .WithOne(c => c.User);
        }
    }
}
