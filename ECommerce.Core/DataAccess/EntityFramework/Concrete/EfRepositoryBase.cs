using ECommerce.Core.DataAccess.EntityFramework.BaseType;

namespace ECommerce.Core.DataAccess.EntityFramework.Concrete
{
    public class EfRepositoryBase<T>: IDeletedRepository<T>,IDeletedRepositoryAsync<T>,
		IUpdatedRepository<T>,IUpdatedRepositoryAsync<T>,
		IAddedRepository<T>,IAddedRepositoryAsync<T>,
		IReadRepository<T>,IReadRepositoryAsync<T> where T: class ,new() 
	{
		public bool Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public bool DeleteAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(T entity)
		{
			throw new NotImplementedException();
		}

		public bool UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public bool Add(T entity)
		{
			throw new NotImplementedException();
		}

		public bool AddAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public T GetAll()
		{
			throw new NotImplementedException();
		}

		public T GetAllAsync()
		{
			throw new NotImplementedException();
		}
	}
}
