using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.DTOs.RetailCustomer
{
	public class RetailCustomerForRegisterVM
	{
		public string FirstName { get; set; }
		public string Lastname { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime Age { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime CreatedDate { get; set; }=DateTime.Now;
		public DateTime UpdatedDate { get; set; }=DateTime.Now;
	}
}
