using Autofac.Core;
using ECommerce.Core.Extensions.Service;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework;
using ECommerce.DataAccess.Concrete.EntityFramework.Context;
using ECommerce.UI.Filter;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
	options.Filters.Add<CustomExceptionFilter>();
});

#region Serilog

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Error()
	.WriteTo.File("C:\\logs\\log-.txt", rollingInterval: RollingInterval.Day)
	.CreateLogger();

#endregion

#region DB Configuration

var connectionString = builder.Configuration.GetConnectionString("ECommerce");
builder.Services.AddDbContext<ECommerceContext>(config => config.UseSqlServer(connectionString));

#endregion

#region DAL Configuration

builder.Services.AddScoped<IUserDal, EfUserDal>();


#endregion

builder.Logging.AddSerilog();

var app = builder.Build();

//logging middleware
app.UseLogging();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
