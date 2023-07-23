namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IReadRepository<T> where T : class, new()
{
	T GetAll();
}