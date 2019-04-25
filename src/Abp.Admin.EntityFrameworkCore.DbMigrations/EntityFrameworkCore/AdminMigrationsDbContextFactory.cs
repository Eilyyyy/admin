using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.Admin.EntityFrameworkCore
{
    public class AdminMigrationsDbContextFactory : IDesignTimeDbContextFactory<AdminMigrationsDbContext>
    {
        public AdminMigrationsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AdminMigrationsDbContext>()
                .UseSqlite("Data Source=sqlite.db;");

            return new AdminMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
