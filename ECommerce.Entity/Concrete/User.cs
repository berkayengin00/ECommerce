using ECommerce.Core.Entity;

namespace ECommerce.Entity.Concrete
{
	public class User:EntityBase
	{
		public string PasswordHash { get; set; }
		public string PasswordSalt { get; set; }
		public string Email { get; set; }
	}
}
