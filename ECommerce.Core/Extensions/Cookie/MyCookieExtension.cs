using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace ECommerce.Core.Extensions.Cookie
{
	public static class MyCookieExtension
	{

		/// <summary>
		/// Parametre olarak cookie name değerini alır.
		/// Key değerine ait cookie varsa geri döner yoksa tipin default değerini döner.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="requestCookie"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static T GetCookie<T>(this IRequestCookieCollection requestCookie, string key)
		{
			return requestCookie[key] == null
				? default(T)
				: JsonSerializer.Deserialize<T>(requestCookie[key]);
		}

		/// <summary>
		/// Parametre olarak gelen Key değerine datayı atar.
		/// Default expires time 1 gündür.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="responseCookies"></param>
		/// <param name="key"></param>
		/// <param name="data"></param>
		/// <param name="expireTime"></param>
		public static void SetCookie<T>(this IResponseCookies responseCookies, string key, object data, int expireTime = 1)
		{
			var option = new CookieOptions
			{
				Expires = DateTime.Now.AddDays(expireTime),
				MaxAge = TimeSpan.FromSeconds(expireTime),
				Domain = "www.ecoeco.com"
			};
			var jsonData = JsonSerializer.Serialize(data);
			responseCookies.Append(key, jsonData);
		}
	}

}
