using System.Linq.Expressions;

namespace ECommerce.Core.Result.BaseType
{
    public interface IAddedService<T> where T : class,new()
	{
		Result Add(T entity);
	}
    public interface IAddedAsyncService<T> where T : class, new()
    {
	    Task<Result> AddAsync(T entity);
    }
	public interface IDeletedService<T> where T : class, new()
    {
	    Result Delete(T entity);
    }
    public interface IUpdatedService<T> where T : class, new()
    {
	    Result Update(T entity);
    }
    public interface IReadService<T> where T : class, new()
    {
	    DataResult<List<T>> GetAll();
    }

}
