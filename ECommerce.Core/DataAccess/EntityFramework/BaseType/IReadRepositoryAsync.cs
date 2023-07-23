using System.Linq.Expressions;

namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IReadRepositoryAsync<T> where T : class, new()
{
	Task<List<T>> GetAllAsync(Expression<Func<T,bool>>? query = null );
}