using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Result.BaseType
{
    public interface IResult{}

    public class Result:IResult
    {
        public string Message { get; }
        public bool IsSuccess { get; }

        public Result(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public Result()
        {
	        
        }

    }
}
