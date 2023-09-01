using ECommerce.Core.Result.BaseType;


namespace ECommerce.Business.Validator.reCaptcha
{
	public interface ICaptchaValidator
	{
		Result IsVerify(string response);
	}
}
