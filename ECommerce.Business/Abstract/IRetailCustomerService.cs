using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Core.Result;
using ECommerce.Core.Result.BaseType;
using ECommerce.Entity.Concrete;
using ECommerce.Entity.DTOs.RetailCustomer;

namespace ECommerce.Business.Abstract
{
	public interface IRetailCustomerService:IAddedService<RetailCustomerForRegisterVM>,IUpdatedService<RetailCustomer>,IDeletedService<RetailCustomer>,IReadService<RetailCustomer>
	{
	}
}
