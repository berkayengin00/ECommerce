using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Core.Result.BaseType;
using ECommerce.Core.Result.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entity.Concrete;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using AutoMapper;
using ECommerce.Core.Security.Hashing;
using ECommerce.Entity.DTOs.RetailCustomer;

namespace ECommerce.Business.Concrete
{
	public class RetailCustomerManager:IRetailCustomerService
	{
		private readonly IRetailCustomerDal _retailCustomerDal;
		private readonly IMapper _mapper;

		public RetailCustomerManager(IRetailCustomerDal retailCustomerDal, IMapper mapper)
		{
			_retailCustomerDal = retailCustomerDal;
			_mapper = mapper;
		}

		public Result Add(RetailCustomerForRegisterVM entity)
		{
			if (RetailCustomerExists(entity.Email))
			{
				return new ErrorResult(Messages.RetailCustomerExists);
			}

			var result = _retailCustomerDal.Add(CreatePasswordHashAndSalt(entity));

			return result == false
				? new ErrorResult(Messages.RetailCustomerNotAdded)
				: new SuccessResult(Messages.RetailCustomerAdded);
		}

		/// <summary>
		/// Daha önce aynı email ile kayıtlı kullanıcı varsa true döner.
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		private bool RetailCustomerExists(string email)
		{
			return _retailCustomerDal.Get(x => x.Email == email) != null;
		}

		/// <summary>
		/// PasswordHash ve PasswordSalt Üretilir. Mapleme işlemi yapılır. Geriye RetailCustomer Döner.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		private RetailCustomer CreatePasswordHashAndSalt(RetailCustomerForRegisterVM entity)
		{
			HashingHelper.CreatePasswordHash(entity.Password, out var passwordHash, out var passwordSalt);
			var user = _mapper.Map<RetailCustomer>(entity);
			user.PasswordHash = passwordHash;
			user.PasswordSalt = passwordSalt;
			return user;
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

		public async Task<Result> AddAsync(RetailCustomerForRegisterVM entity)
		{
			if (RetailCustomerExists(entity.Email))
			{
				return new ErrorResult(Messages.RetailCustomerExists);
			}

			var result = await _retailCustomerDal.AddAsync(CreatePasswordHashAndSalt(entity));

			return result == false
				? new ErrorResult(Messages.RetailCustomerNotAdded)
				: new SuccessResult(Messages.RetailCustomerAdded);
		}
	}
}
