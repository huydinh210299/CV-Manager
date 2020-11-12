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
            builder.Property(cv => cv.ID).HasDefaultValue(Guid.NewGuid());
            builder.Property(cv => cv.CvName).IsRequired();
            builder.Property(cv => cv.Name).IsRequired();
            builder.Property(cv => cv.Html).IsRequired();
            builder.Property(cv => cv.Css).IsRequired();
            builder.Property(cv => cv.Type).IsRequired();
            builder.Property(cv => cv.Status).HasDefaultValue(1);
            builder.Property(cv => cv.Is_choosen).HasDefaultValue(false);
            builder.Property(cv => cv.createDate).HasDefaultValue(DateTime.Now);

        }
    }
}
