using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Zoo.Domain;

namespace Zoo.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EARelation> EARelations { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
