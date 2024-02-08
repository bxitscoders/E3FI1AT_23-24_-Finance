using FinanceWeb.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace FinanceWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        const string connectionString = "server=localhost;user=root;database=financeapp;password=;";

        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Shares> Shares { get; set; }
        public DbSet<ShareValue> ShareValue { get; set; }
        public DbSet<Possession> Possession { get; set; }
        public DbSet<ApiDetails> ApiDetails { get; set; }
        public DbSet<FinanceTransaction> FinanceTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
