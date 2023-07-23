namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IUpdatedRepositoryAsync<T> where T : class, new()
{
	bool UpdateAsync(T entity);
}