using System.Linq.Expressions;

namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IGetRepositoryAsync<T> where T : class, new()
{
	Task<T> GetAsync(Expression<Func<T, bool>> query);
}