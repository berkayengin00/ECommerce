using ECommerce.Core.Entity;

namespace ECommerce.Entity.Concrete
{
	public class User:EntityBase
	{
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
		public string Email { get; set; }
	}
}
