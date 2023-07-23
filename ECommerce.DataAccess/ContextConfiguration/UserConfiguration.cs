using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.ContextConfiguration;

public class UserConfiguration:IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.ToTable("User");

		builder.Property(x => x.Email).IsRequired().HasMaxLength(256);
		builder.HasIndex(x => x.Email).IsUnique();
		builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(500);
		builder.Property(x => x.PasswordSalt).IsRequired().HasMaxLength(500);
	}
}