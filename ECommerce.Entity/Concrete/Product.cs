using ECommerce.Core.Entity;

namespace ECommerce.Entity.Concrete
{
	public class Product:EntityBase
	{
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public int CategoryId { get; set; }

		public Category Category { get; set; }

	}
}
