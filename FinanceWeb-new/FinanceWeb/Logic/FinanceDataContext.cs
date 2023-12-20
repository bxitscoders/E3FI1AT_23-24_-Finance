using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace FinanceWeb.Logic
{
    public class FinanceDataContext : DbContext
    {
        const string connectionString = "server=localhost;user=root;database=financeapp;password=;";

        public FinanceDataContext() { }
        public FinanceDataContext(DbContextOptions<FinanceDataContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Shares> Shares { get; set; }
        public DbSet<ShareValue> ShareValues { get; set; }
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
