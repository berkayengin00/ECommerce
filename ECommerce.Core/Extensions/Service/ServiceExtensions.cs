using ECommerce.Core.Log;
using Microsoft.AspNetCore.Builder;

namespace ECommerce.Core.Extensions.Service
{
	public static class LoggingMiddlewareExtension
	{
		public static IApplicationBuilder UseLogging(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<LoggingMiddleware>();
		}
	}
}
