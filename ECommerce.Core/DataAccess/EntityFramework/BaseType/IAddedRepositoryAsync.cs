namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IAddedRepositoryAsync<T> where T : class, new()
{
	Task<bool> AddAsync(T entity);
}