﻿using Abp.Admin.Entities;
using Microsoft.EntityFrameworkCore;
using Abp.Admin.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Abp.Admin.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class AdminDbContext : AbpDbContext<AdminDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Company> Companies { get; set; }

        public AdminDbContext(DbContextOptions<AdminDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureFullAudited();
                b.ConfigureExtraProperties();
                b.ConfigureConcurrencyStamp();
                b.ConfigureAbpUser();

                //Moved customization to a method so we can share it with the AdminMigrationsDbContext class
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureAdmin method */

            builder.ConfigureAdmin();
        }
    }
}
