using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.ContextConfiguration
{
	public class ProductConfiguration:IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("Product");
			
			builder.HasKey(x => x.Id);
			builder.Property(x=>x.ProductName).HasMaxLength(80).IsRequired();
			builder.Property(x => x.ProductDescription).HasMaxLength(500).IsRequired();
			builder.Property(x => x.Price).IsRequired().HasPrecision(18,2);
			builder.Property(x => x.ProductDescription).IsRequired();

			//builder.HasOne<Category>()
			//	.WithMany()
			//	.HasForeignKey(x=>x.CategoryId).IsRequired();
		}
	}
}
