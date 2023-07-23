namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IUpdatedRepository<T> where T : class, new()
{
	bool Update(T entity);
}