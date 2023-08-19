using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.DTOs.User
{
	public class UserForLogin
	{
		[Required(ErrorMessage = "Email Zorunludur !")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Parola Zorunludur !")]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
		
	}
}
