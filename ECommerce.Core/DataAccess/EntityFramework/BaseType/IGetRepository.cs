namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IGetRepository<T> where T : class, new()
{
	T Get(Func<T, bool> query);
}