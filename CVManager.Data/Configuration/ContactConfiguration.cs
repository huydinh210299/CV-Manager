using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd();
            builder.Property(c => c.Status).HasDefaultValue(true).IsRequired();
            builder.Property(c => c.Type).IsRequired();
            builder.Property(c => c.Result).HasDefaultValue("pending").IsRequired();
            builder.Property(c => c.createDate).ValueGeneratedOnAdd();

            builder.HasOne(c => c.ContactInfo)
                .WithOne(i => i.Contact)
                .HasForeignKey<ContactInfo>(i => i.ID_Contact);
        }
    }
}
