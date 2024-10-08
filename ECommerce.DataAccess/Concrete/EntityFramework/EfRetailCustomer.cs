﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Core.DataAccess.EntityFramework.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework.Context;
using ECommerce.Entity.Concrete;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
	public class EfRetailCustomer:EfRepositoryBase<RetailCustomer,ECommerceContext>,IRetailCustomerDal
	{
		public EfRetailCustomer(ECommerceContext db) : base(db)
		{
		}
	}
}
