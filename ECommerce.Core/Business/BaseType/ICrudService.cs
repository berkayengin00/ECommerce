﻿namespace ECommerce.Core.Result.BaseType
{
    public interface IAddedService<T> where T : class,new()
	{
		Result Add(T entity);
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
	    Result GetAll(T entity);
    }

}
