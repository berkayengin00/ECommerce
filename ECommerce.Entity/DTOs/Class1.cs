using Newtonsoft.Json;

namespace ECommerce.Entity.DTOs
{
	public class CaptchaResponse
	{
		[JsonProperty("success")]
		public bool Success { get; set; }

		[JsonProperty("error-codes")]
		public List<string> ErrorCodes { get; set; }
	}
}
