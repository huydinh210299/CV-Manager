using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    class CVConfiguration : IEntityTypeConfiguration<CV>
    {
        public void Configure(EntityTypeBuilder<CV> builder)
        {
            builder.ToTable("CV");
            builder.HasKey(cv => cv.ID);
            builder.Property(cv => cv.Name).IsRequired();
            builder.Property(cv => cv.Phone).IsRequired();
            builder.Property(cv => cv.Email).IsRequired();
            builder.Property(cv => cv.Html).IsRequired();
            builder.Property(cv => cv.Css).IsRequired();
            builder.Property(cv => cv.Type).IsRequired();
            builder.Property(cv => cv.Status).IsRequired().HasDefaultValue(1);
            builder.Property(cv => cv.Is_choosen).IsRequired().HasDefaultValue(true);
        }
    }
}
