using ECommerce.Core.Result.Concrete;
using ECommerce.Core.Security.Hashing;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;

namespace ECommerce.NUnitTest
{
	public class Tests
	{
		private IRetailCustomerDal retailCustomerDal;
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void PasswordHash_Test()
		{
			var password = "berk";
			HashingHelper.CreatePasswordHash(password, out var passwordHash, out var passwordSalt);

			var result = HashingHelper.VerifyPasswordHash(password, passwordHash, passwordSalt);
			Assert.AreEqual(true, result);

			var resultFalse = HashingHelper.VerifyPasswordHash("ber", passwordHash, passwordSalt);
			Assert.AreEqual(false, resultFalse);
		}
	}
}