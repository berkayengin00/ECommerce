using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;

namespace ECommerce.UI.Filter
{
	public class CustomExceptionFilter : IExceptionFilter
	{
		public void OnException(ExceptionContext context)
		{
			Log.Error(context.Exception, "An exception occurred in {Action} action of {Controller}",
				context.ActionDescriptor.RouteValues["action"],
				context.ActionDescriptor.RouteValues["controller"]);

			
			context.Result = new ObjectResult("An error occurred.")
			{
				StatusCode = 500
			};

			context.ExceptionHandled = true;
		}
	}
}
