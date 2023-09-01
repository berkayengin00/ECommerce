using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.Business.Mapping.AutoMapper;
using ECommerce.Business.Validator.FluentValidation;
using ECommerce.Business.Validator.reCaptcha;
using ECommerce.Core.Extensions.Service;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework;
using ECommerce.DataAccess.Concrete.EntityFramework.Context;
using ECommerce.Entity.DTOs.RetailCustomer;
using ECommerce.UI.Filter;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
	options.Filters.Add<CustomExceptionFilter>();

});

builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddScoped<IValidator<RetailCustomerForRegisterVM>, RetailCustomerVmValidator>();

#region GoogleAuthentication

builder.Services.AddAuthentication(options =>
{
	//options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
	options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddGoogle(options =>
{
	options.ClientId = builder.Configuration["GoogleLogin:ClientId"];
	options.ClientSecret = builder.Configuration["GoogleLogin:SecretKey"];
	options.CallbackPath = "/Account/GoogleResponse";

});

#endregion

#region AutoMapper

builder.Services.AddAutoMapper(typeof(MappingProfile));

#endregion

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

#region Business Configuraiton

builder.Services.AddScoped<IRetailCustomerService, RetailCustomerManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IAccountService, AccountManager>();
builder.Services.AddScoped<ICaptchaValidator, CaptchaValidator>();

#endregion

#region DAL Configuration

builder.Services.AddScoped<IRetailCustomerDal, EfRetailCustomer>();
builder.Services.AddScoped<IUserDal, EfUserDal>();


#endregion

builder.Services.AddHttpContextAccessor();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
