using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CVManager.Data.EF
{
    public class CVManagerDBContextfactory : IDesignTimeDbContextFactory<CVManagerDBContext>
    {
        public CVManagerDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CVManagerDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<CVManagerDBContext>();
            optionsBuilder.UseMySql(connectionString, 
                mySqlOptions => mySqlOptions.ServerVersion(new Version(10, 5, 6), ServerType.MariaDb));
            return new CVManagerDBContext(optionsBuilder.Options);
        }
    }
}
