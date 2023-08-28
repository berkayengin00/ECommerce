using System.Net;
using ECommerce.Core.Result.BaseType;
using ECommerce.Entity.DTOs;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ECommerce.Business.Validator.reCaptcha;

public class CaptchaValidator:ICaptchaValidator
{
	private readonly IConfiguration _configuration;

	public CaptchaValidator(IConfiguration configuration)
	{
		_configuration = configuration;
	}
	public Result IsVerify(string response)
	{
		if (string.IsNullOrEmpty(response)) return new ErrorResult();
			
		var secretKey = _configuration["Captchav2:SecretKey"];

		var client = new WebClient();
		var reply = client.DownloadString($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={response}");

		var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(reply);

		return captchaResponse is {Success:true} ? new SuccessResult() : new ErrorResult();
	}
}