using ECommerce.Core.DataAccess.EntityFramework.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
	public class EfUserDal:EfRepositoryBase<User>,IUserDal
	{
	}
}
