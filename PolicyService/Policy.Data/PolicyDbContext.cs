﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Linq;
using Policy.Data.Entities;
using Policy.Data.KernelAttributes;

namespace Policy.Data.EF
{
    public class PolicyDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PolicyDbContext(DbContextOptions<PolicyDbContext> options) : base(options) { }

       
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modifiedObject = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (EntityEntry item in modifiedObject)
            {
                var updateOrAddObject = item.Entity as IDateTracking;
                if (updateOrAddObject != null)
                {
                    if (item.State == EntityState.Added && (updateOrAddObject.CreatedDate == null || updateOrAddObject.CreatedDate == new DateTime(1, 1, 1)))
                    {
                        updateOrAddObject.CreatedDate = DateTime.Now;
                    }
                    else
                    {
                        updateOrAddObject.UpdatedDate = DateTime.Now;
                    }
                }
            }
            return base.SaveChanges();
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PolicyDbContext>
    {
        public const string ConnectString = "Server=.;Database=Policy_DB;Trusted_Connection=True;MultipleActiveResultSets=true";

        public PolicyDbContext CreateDbContext(string[] args)
        {
            //IConfiguration configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<PolicyDbContext>();
            //var connectionString = configuration.GetConnectionString("VSIT_IC_Context");
            builder.UseSqlServer(ConnectString);
            return new PolicyDbContext(builder.Options);
        }
    }
}
