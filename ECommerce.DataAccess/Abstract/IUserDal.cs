using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Core.DataAccess.EntityFramework.BaseType;
using ECommerce.Entity.Concrete;

namespace ECommerce.DataAccess.Abstract
{
	public interface IUserDal:IAddedRepository<User>,IAddedRepositoryAsync<User>,IReadRepositoryAsync<User>,IReadRepository<User>
	{
	}
}
