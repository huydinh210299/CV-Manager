using CVManager.Data.Configuration;
using CVManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVManager.Data.EF
{
    public class CVManagerDBContext : DbContext
    {
        public CVManagerDBContext(DbContextOptions options) : base(options)
        {
            
        }

        /*
         * Add config to entity
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new EnterpriseConfiguration());
            modelBuilder.ApplyConfiguration(new EnterpriseInfoConfiguration());
            modelBuilder.ApplyConfiguration(new AcountConfiguration());
            modelBuilder.ApplyConfiguration(new CVConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ContactInfoConfiguration());
            //base.OnModelCreating(modelBuilder);
        }

        /*
         *Add DBSet 
         */
        public DbSet<User> Users { get; set; }
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Acount> Acounts { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<EnterpriseInfo> EnterpriseInfos { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
    }
}
