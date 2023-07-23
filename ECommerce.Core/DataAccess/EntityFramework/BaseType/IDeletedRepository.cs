using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.DataAccess.EntityFramework.BaseType
{
    public interface IDeletedRepository<T> where T : class, new()
    {
        bool Delete(T entity);
    }
}
