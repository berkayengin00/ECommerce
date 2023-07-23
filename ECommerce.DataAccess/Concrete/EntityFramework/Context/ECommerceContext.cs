using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccess.ContextConfiguration;
using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Context
{
	public class ECommerceContext:DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<RetailCustomer> RetailCustomers { get; set; }
		public DbSet<SellerCustomer> SellerCustomers { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Role> Roles { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=ECommerceDB;Trusted_Connection=true;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
			modelBuilder.ApplyConfiguration(new SellerCustomerConfiguration());
			modelBuilder.ApplyConfiguration(new RetailCustomerConfiguration());
			modelBuilder.ApplyConfiguration(new RoleConfiguration());
			modelBuilder.ApplyConfiguration(new UserConfiguration());
		}
	}

}
