using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity.DTOs.RetailCustomer;
using FluentValidation;

namespace ECommerce.Business.Validator.FluentValidation
{
	public class RetailCustomerVmValidator:AbstractValidator<RetailCustomerForRegisterVM>
	{
		public RetailCustomerVmValidator()
		{
			RuleFor(x=> x.FirstName)
				.NotEmpty()
				.WithMessage("Lütfen adınızı giriniz.")
				.MinimumLength(3)
				.WithMessage("Adınız en az 3 karakter olamalıdır.")
				.MaximumLength(50)
				.WithMessage("Adınız 50 karakterden fazla olamaz");
		}
	}
}
