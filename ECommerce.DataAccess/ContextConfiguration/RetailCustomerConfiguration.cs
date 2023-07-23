using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.ContextConfiguration;

public class RetailCustomerConfiguration : IEntityTypeConfiguration<RetailCustomer>
{
	public void Configure(EntityTypeBuilder<RetailCustomer> builder)
	{
		builder.ToTable("RetailCustomer");

		builder.Property(x => x.FirstName).HasMaxLength(100);
		builder.Property(x=>x.Lastname).IsRequired().HasMaxLength(100);
		builder.Property(x => x.Age).IsRequired();

	}
}