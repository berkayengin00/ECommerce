using ECommerce.Business.Abstract;
using ECommerce.Core.Extensions.Cookie;
using ECommerce.Entity.DTOs.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
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

		public IActionResult GoogleLogin()
		{
			var redirectUrl = Url.Action("GoogleResponse", "Account", null, protocol: HttpContext.Request.Scheme);
			var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
			return Challenge(properties, GoogleDefaults.AuthenticationScheme);
		}

		public async Task<IActionResult> GoogleResponse()
		{
			var authenticateResult = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
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
