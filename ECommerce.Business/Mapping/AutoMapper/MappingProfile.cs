using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Entity.Concrete;
using ECommerce.Entity.DTOs.RetailCustomer;

namespace ECommerce.Business.Mapping.AutoMapper
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<RetailCustomerForRegisterVM,RetailCustomer>();
			CreateMap<RetailCustomer, RetailCustomerForRegisterVM>();
		}
	}
}
