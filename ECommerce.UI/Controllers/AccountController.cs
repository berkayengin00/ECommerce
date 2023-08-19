using ECommerce.Business.Abstract;
using ECommerce.Core.Result.BaseType;
using ECommerce.Entity.Concrete;
using ECommerce.Entity.DTOs.User;
using ECommerce.UI.Utilities.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Controllers
{
	public class AccountController : Controller
	{

		private readonly IAccountService _accountService;

		public AccountController(IAccountService accountService)
		{
			_accountService = accountService;
		}

		[HttpGet]
		public IActionResult Login()
		{
			var result = Request.Cookies.GetCookie<UserForLogin>("RememberMe");
			return View(result);
		}

		[HttpPost,ValidateAntiForgeryToken]
		public IActionResult Login(UserForLogin user)
		{
			if (!ModelState.IsValid) return View();

			var result = _accountService.CheckUser(user);
			if (!result.IsSuccess) return View(user);

			RememberMe(user);
			return RedirectToAction("Index", "Home");

		}

		[NonAction]
		public void RememberMe(UserForLogin user)
		{
			if (user.RememberMe)
			{
				Response.Cookies.SetCookie<UserForLogin>("RememberMe", user,3);
			}
		}

	}
}
