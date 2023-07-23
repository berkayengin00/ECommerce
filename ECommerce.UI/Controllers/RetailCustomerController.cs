using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Controllers
{
	public class RetailCustomerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
