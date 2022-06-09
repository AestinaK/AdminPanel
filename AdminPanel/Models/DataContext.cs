using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using System.IO;

namespace AdminPanel.Models
{
    public class DataContext: DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json");

			var configuration = builder.Build();
			optionsBuilder.UseMySql(configuration
				["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 11)));

		}

		//Need to register your models here
		public DbSet<Add> ?pcs { get; set; }
		public DbSet<AddC> ?cat { get; set; }
	}
}
