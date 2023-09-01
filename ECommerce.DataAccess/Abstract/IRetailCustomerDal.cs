using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Core.DataAccess.EntityFramework.BaseType;
using ECommerce.Entity.Concrete;

namespace ECommerce.DataAccess.Abstract
{
    public interface IRetailCustomerDal:IReadRepository<RetailCustomer>,IDeletedRepository<RetailCustomer>,IUpdatedRepository<RetailCustomer>,IAddedRepository<RetailCustomer>,IGetRepository<RetailCustomer>,IAddedRepositoryAsync<RetailCustomer>
	{
	}
}
