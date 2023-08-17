using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Core.Result.BaseType;
using ECommerce.Core.Result.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;
using System.Linq.Expressions;

namespace ECommerce.Business.Concrete
{
	public class RetailCustomerManager:IRetailCustomerService
	{
		private readonly IRetailCustomerDal _retailCustomerDal;
		public RetailCustomerManager(IRetailCustomerDal retailCustomerDal)
		{
			_retailCustomerDal = retailCustomerDal;
		}

		public Result Add(RetailCustomer entity)
		{
			var result = _retailCustomerDal.Add(entity);

			return result == false 
				? new ErrorResult(Messages.RetailCustomerNotAdded) 
				: new SuccessResult(Messages.RetailCustomerAdded);
		}

		public Result Update(RetailCustomer entity)
		{
			var result = _retailCustomerDal.Update(entity);

			return result == false
				? new ErrorResult(Messages.RetailCustomerNotUpdated)
				: new SuccessResult(Messages.RetailCustomerUpdated);
		}

		public Result Delete(RetailCustomer entity)
		{
			var result = _retailCustomerDal.Delete(entity);

			return result == false
				? new ErrorResult(Messages.RetailCustomerNotDeleted)
				: new SuccessResult(Messages.RetailCustomerDeleted);
		}

		public DataResult<List<RetailCustomer>> GetAll()
		{
			var result = _retailCustomerDal.GetAll();

			return result == null
				? new ErrorDataResult<List<RetailCustomer>>(Messages.RetailCustomerNotGetAll)
				: new SuccessDataResult<List<RetailCustomer>>(Messages.RetailCustomerGetAll, result);
		}
	}
}
