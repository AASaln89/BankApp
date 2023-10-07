using BankApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Repository.PostgreSQL
{
    public class BankAppContext : DbContext
    {
        public BankAppContext(DbContextOptions<BankAppContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<Deposit> Deposits { get; set; }

        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
