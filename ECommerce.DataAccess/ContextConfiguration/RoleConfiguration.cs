using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.ContextConfiguration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
	public void Configure(EntityTypeBuilder<Role> builder)
	{
		builder.ToTable("Role");

		builder.HasData(new Role[]
		{
			new() {Id = 1,RoleName = "SuperAdmin",CreatedDate = DateTime.Now,Status = true,UpdatedDate = DateTime.Now},
			//new() {Id = 2,RoleName = "Admin",CreatedDate = DateTime.Now},
			//new() {Id = 3,RoleName = "Moderator",CreatedDate = DateTime.Now},
			//new() {Id = 4,RoleName = "RetailCustomer" ,CreatedDate = DateTime.Now},
			//new() {Id = 5,RoleName = "SellerCustomer" ,CreatedDate = DateTime.Now},
		});
	}
}