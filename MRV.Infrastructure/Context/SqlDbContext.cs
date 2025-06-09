using Microsoft.EntityFrameworkCore;
using MRV.Domain.Entities;
using MRV.Infrastructure.Configuration;

namespace MRV.Infrastructure.Context
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {   
        }

        public DbSet<Lead> Leads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LeadConfiguration());
        }
    }
}
