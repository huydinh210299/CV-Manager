
using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.ExactAddress).IsRequired();
            builder.Property(p => p.Position).IsRequired();
            builder.Property(p => p.Gender).IsRequired();
            builder.Property(p => p.Salary).IsRequired();
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Type).IsRequired();
            builder.Property(p => p.Experience).IsRequired();
            builder.Property(p => p.Submit_Deadline).IsRequired();
            builder.Property(p => p.Reciever).IsRequired();
            builder.Property(p => p.Email_Reciever).IsRequired();
            builder.Property(p => p.Phone_Reciever).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Require).IsRequired();
            builder.Property(p => p.Benefit).IsRequired();
            builder.Property(p => p.Skill).IsRequired();
            builder.Property(p => p.Status).HasDefaultValue(true);
            builder.Property(p => p.createDate).ValueGeneratedOnAdd();

            builder.HasMany(p => p.Contacts)
                .WithOne(c => c.Post);
        }
    }
}
