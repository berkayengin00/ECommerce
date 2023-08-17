using System.Linq.Expressions;
using ECommerce.Core.DataAccess.EntityFramework.BaseType;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Core.DataAccess.EntityFramework.Concrete
{
    public class EfRepositoryBase<T,TContext>: IDeletedRepository<T>,IDeletedRepositoryAsync<T>,
		IUpdatedRepository<T>,IUpdatedRepositoryAsync<T>,
		IAddedRepository<T>,IAddedRepositoryAsync<T>,
		IReadRepository<T>,IReadRepositoryAsync<T>,IGetRepository<T>,IGetRepositoryAsync<T> where T: class ,new() where TContext : DbContext
    {
	    private TContext _db;

	    public EfRepositoryBase(TContext db)
	    {
		    _db = db;
	    }
		public bool Delete(T entity)
		{
			_db.Remove(entity);
			return _db.SaveChanges()>0;
		}

		public async Task<bool> DeleteAsync(T entity)
		{
			_db.Remove(entity);
			var result = await _db.SaveChangesAsync()>0;
			return await Task.FromResult(result);

		}

		public bool Update(T entity)
		{
			_db.Update(entity);
			return _db.SaveChanges()>0;
		}

		public async Task<bool> UpdateAsync(T entity)
		{
			_db.Update(entity);
			var result = await _db.SaveChangesAsync()>0;
			return await Task.FromResult(result);
		}

		public bool Add(T entity)
		{
			_db.Add(entity);
			return _db.SaveChanges()>0;
		}

		public async Task<bool> AddAsync(T entity)
		{
			await _db.AddAsync(entity);
			var result = await _db.SaveChangesAsync()>0;
			return await Task.FromResult(result);
		}

		public List<T> GetAll(Func<T, bool>? query = null)
		{
			return query == null
				? _db.Set<T>().ToList()
				: _db.Set<T>().Where(query).ToList();
		}


		public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? query = null)
		{
			return query == null
				? await _db.Set<T>().ToListAsync()
				: await _db.Set<T>().Where(query).ToListAsync();
		}

		public T Get(Func<T, bool> query)
		{
			return _db.Set<T>().FirstOrDefault(query);
		}

		public Task<T> GetAsync(Expression<Func<T, bool>>? query = null)
		{
			return _db.Set<T>().FirstOrDefaultAsync(query);
		}
    }
}
