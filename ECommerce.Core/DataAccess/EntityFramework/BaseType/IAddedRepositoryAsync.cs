namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IAddedRepositoryAsync<T> where T : class, new()
{
	bool AddAsync(T entity);
}