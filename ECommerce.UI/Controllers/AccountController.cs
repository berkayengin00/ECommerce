using ECommerce.Business.Abstract;
using ECommerce.Core.Result.BaseType;
using ECommerce.Entity.DTOs.User;
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
			return View(new UserForLogin());
		}

		[HttpPost,ValidateAntiForgeryToken]
		public IActionResult Login(UserForLogin user)
		{
			var result = _accountService.CheckUser(user);
			if (result.IsSuccess)
			{
				return RedirectToAction("Index","Home");
			}
			return View();
		}
	}
}
