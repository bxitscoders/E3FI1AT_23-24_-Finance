using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceWeb.Logic
{
	public class FinanceDataContext: DbContext
	{
		static readonly string connectionString = "server=localhost;user=root;database=financeapp;password=;";

		public DbSet<User> User { get; set; }
		public DbSet<Account> Account { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
		}
	}
}
