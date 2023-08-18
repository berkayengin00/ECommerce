using ECommerce.Business.Abstract;
using ECommerce.Core.Result.Concrete;
using ECommerce.Core.Security.Hashing;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;
using ECommerce.Entity.DTOs.User;

namespace ECommerce.NUnitTest
{
	public class Tests
	{
		private IRetailCustomerDal retailCustomerDal;
		private IAccountService _accountService; 
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void PasswordHash_Test()
		{
			var asass = _accountService.CheckUser(new UserForLogin() { Email = "berk@berk.com", Password = "345" });
			User tes = new User();

			var password = "berk";
			HashingHelper.CreatePasswordHash(password, out var passwordHash, out var passwordSalt);

			var result = HashingHelper.VerifyPasswordHash(password, passwordHash, passwordSalt);
			Assert.AreEqual(true, result);

			var resultFalse = HashingHelper.VerifyPasswordHash("ber", passwordHash, passwordSalt);
			Assert.AreEqual(false, resultFalse);
		}
	}
}