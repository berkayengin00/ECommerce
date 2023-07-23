using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Controllers
{
	public class RetailCustomerController : Controller
	{
		private IUserDal _userDal;

		public RetailCustomerController(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public async Task<IActionResult> GetAllUser()
		{
			var result = await _userDal.GetAllAsync();
			return Json(result);
		}
	}
}
