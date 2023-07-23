using ECommerce.Core.Entity;

namespace ECommerce.Entity.Concrete
{
	public class User:EntityBase
	{
		public string PasswordHash { get; set; }
		public string PasswordSalt { get; set; }
		public string Email { get; set; }
	}

	public class RetailCustomer:User
	{
		public string FirstName { get; set; }
		public string Lastname { get; set; }
		public DateTime Age { get; set; }
	}

	public class SellerCustomer:User
	{
		public string TaxNo { get; set; }
	}

	public class Employee : User
	{
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
