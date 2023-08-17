using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;
using ECommerce.Entity.DTOs.RetailCustomer;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Controllers
{
	public class RetailCustomerController : Controller
	{
		private readonly IRetailCustomerService _retailCustomerService;
		public RetailCustomerController(IRetailCustomerService retailCustomerService)
		{
			_retailCustomerService = retailCustomerService;
		}

		public async Task<IActionResult> Register()
		{
			var user = new RetailCustomerForRegisterVM()
			{
				Email = "berk@berk.com",
				Age = DateTime.Now,
				FirstName = "Berk",
				Lastname = "Ay",
				Password = "345"
			};

			var result = _retailCustomerService.Add(user);
			return null;
		}
	}
}
