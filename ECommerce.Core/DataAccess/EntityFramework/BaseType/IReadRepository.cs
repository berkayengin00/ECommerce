namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IReadRepository<T> where T : class, new()
{
	List<T> GetAll(Func<T,bool>? query=null);
}