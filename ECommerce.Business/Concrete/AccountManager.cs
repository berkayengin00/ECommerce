using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Core.Result.BaseType;
using ECommerce.Core.Result.Concrete;
using ECommerce.Core.Security.Hashing;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;
using ECommerce.Entity.DTOs.User;

namespace ECommerce.Business.Concrete
{
	public class AccountManager:IAccountService
	{
		private readonly IUserDal _userDal;
		public AccountManager(IUserDal userDal)
		{
			_userDal = userDal;
		}
		public DataResult<User> CheckUser(UserForLogin user)
		{
			// Girilen şifreye göre passwordHash ve passwordSalt değerleri oluşturuluyor Db de kontrol etmek için
			HashingHelper.CreatePasswordHash(user.Password,out var passwordHash,out var passwordSalt);

			var result = _userDal.Get(x =>
				x.Email == user.Email && x.PasswordHash == passwordHash && x.PasswordSalt == passwordSalt);

			return result!=null
				? new SuccessDataResult<User>(Messages.AccountInformationIsCorrect, result)
				: new ErrorDataResult<User>(Messages.UserNotFound);

		}
	}
}
