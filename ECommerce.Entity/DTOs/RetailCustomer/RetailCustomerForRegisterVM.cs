using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.DTOs.RetailCustomer
{
	public class RetailCustomerForRegisterVM
	{

		public string FirstName { get; set; }
		public string Lastname { get; set; }
		public DateTime Age { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
