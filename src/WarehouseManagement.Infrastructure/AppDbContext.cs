using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using WarehouseManagement.Domain.Entities;
using WarehouseManagement.Infrastructure.Configuration;

namespace WarehouseManagement.Infrastructure
{
	public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
	{
		public DbSet<Product> Products => Set<Product>();
		public DbSet<Category> Categories => Set<Category>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}
