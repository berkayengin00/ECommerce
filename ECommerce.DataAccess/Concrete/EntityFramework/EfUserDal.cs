using ECommerce.Core.DataAccess.EntityFramework.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework.Context;
using ECommerce.Entity.Concrete;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
	public class EfUserDal:EfRepositoryBase<User,ECommerceContext>,IUserDal
	{
		public EfUserDal(ECommerceContext db) : base(db)
		{
		}
	}
}
