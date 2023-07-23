namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IDeletedRepositoryAsync<T> where T : class, new()
{
	Task<bool> DeleteAsync(T entity);
}