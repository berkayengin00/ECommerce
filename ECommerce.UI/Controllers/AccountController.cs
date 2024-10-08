﻿using ECommerce.Business.Abstract;
using ECommerce.Core.Extensions.Cookie;
using ECommerce.Entity.DTOs.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using ECommerce.Business.Validator.reCaptcha;
using ECommerce.Entity.DTOs.RetailCustomer;

namespace ECommerce.UI.Controllers
{
	public class AccountController : Controller
	{

		private readonly IAccountService _accountService;
		private readonly IRetailCustomerService _retailCustomerService;
		private readonly ICaptchaValidator _captchaValidator;

		public AccountController(IAccountService accountService, IRetailCustomerService customerService, ICaptchaValidator captchaValidator)
		{
			_accountService = accountService;
			_retailCustomerService = customerService;
			_captchaValidator = captchaValidator;
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
			if (!ModelState.IsValid || !IsVerifyCaptcha()) return View();
			
			var result = _accountService.CheckUser(user);
			if (!result.IsSuccess) return View(user);

			RememberMe(user);
			return RedirectToAction("Index", "Home");

		}

		[HttpGet]
		public IActionResult RegisterForRetailCustomer()
		{
			return View(new RetailCustomerForRegisterVM());
		}

		[HttpPost,ValidateAntiForgeryToken]
		public async Task<IActionResult> RegisterForRetailCustomer(RetailCustomerForRegisterVM user)
		{
			if(!ModelState.IsValid) return View();

			var result = await _retailCustomerService.AddAsync(user);
			if (!result.IsSuccess) return View(user);
			
			return RedirectToAction("Index","Home");
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

		/// <summary>
		/// Captcha Doğrulama servisine gider ve kontrol eder.
		/// </summary>
		/// <returns>True or False</returns>
		[NonAction]
		public bool IsVerifyCaptcha()
		{
			var response = Request.Form["g-recaptcha-response"];
			var captchaResult = _captchaValidator.IsVerify(response);

			return captchaResult.IsSuccess;
		}
	}
}
