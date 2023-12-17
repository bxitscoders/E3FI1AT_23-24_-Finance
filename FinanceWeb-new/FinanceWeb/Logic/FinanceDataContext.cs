using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace FinanceWeb.Logic
{
    public class FinanceDataContext : DbContext
    {
        static readonly string connectionString = "server=localhost;user=root;database=financeapp;password=;";

        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Shares> Shares { get; set; }
        public DbSet<ShareValue> ShareValues { get; set; }
        public DbSet<Possession> Possession { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
