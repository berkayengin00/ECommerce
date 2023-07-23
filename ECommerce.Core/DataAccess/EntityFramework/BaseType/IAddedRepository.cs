namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IAddedRepository<T> where T : class, new()
{
	bool Add(T entity);
}