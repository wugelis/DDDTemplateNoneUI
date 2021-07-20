using System;
using System.Threading.Tasks;
using Mcut.Application.Common.Interfaces;
using Mcut.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Mcut.Infrastructure.Persistance
{
    public partial class ApplicationDbContext : DbContext , IApplicationDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		
		public virtual DbSet<AccountEnt> Account { get; set; }
		public virtual DbSet<CustomerDetailEnt> CustomerDetail { get; set; }
		public virtual DbSet<HosingLoansDataEnt> HosingLoansData { get; set; }

		
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=(local)\\MSSQLSERVER2017;Database=Northwind;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public Task<int> SaveChangesAsync(bool cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}


