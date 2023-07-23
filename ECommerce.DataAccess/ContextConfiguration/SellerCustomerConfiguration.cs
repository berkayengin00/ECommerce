using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.ContextConfiguration;

public class SellerCustomerConfiguration : IEntityTypeConfiguration<SellerCustomer>
{
	public void Configure(EntityTypeBuilder<SellerCustomer> builder)
	{
		builder.ToTable("SellerCustomer");

		builder.Property(x => x.TaxNo).IsRequired();
	}
}