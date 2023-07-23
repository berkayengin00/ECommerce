using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.ContextConfiguration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
	public void Configure(EntityTypeBuilder<Employee> builder)
	{
		builder.ToTable("Employee");

		builder.Property(x=>x.FirstName).IsRequired().HasMaxLength(100);
		builder.Property(x=>x.LastName).IsRequired().HasMaxLength(100);
		builder.Property(x=>x.UserName).IsRequired().HasMaxLength(50);

	}
}