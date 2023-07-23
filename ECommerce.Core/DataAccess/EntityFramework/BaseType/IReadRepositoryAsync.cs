namespace ECommerce.Core.DataAccess.EntityFramework.BaseType;

public interface IReadRepositoryAsync<T> where T : class, new()
{
	T GetAllAsync();
}