using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Core.Result.BaseType;
using ECommerce.Core.Result.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;

namespace ECommerce.Business.Concrete
{
	public class UserManager:IUserService
	{
		private readonly IUserDal _userDal;
		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public DataResult<List<User>> GetAll()
		{
			var result = _userDal.GetAll();
			 return result == null
				? new ErrorDataResult<List<User>>(Messages.UserNotGetAll)
				: new SuccessDataResult<List<User>>(Messages.UserGetAll, result);
		}

		
	}
}
