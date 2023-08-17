using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Core.DataAccess.EntityFramework.BaseType;
using ECommerce.Core.Result.BaseType;
using ECommerce.Entity.Concrete;
using ECommerce.Entity.DTOs.User;

namespace ECommerce.Business.Abstract
{
	public interface IAccountService
	{
		public DataResult<User> CheckUser(UserForLogin user);
	}
}
