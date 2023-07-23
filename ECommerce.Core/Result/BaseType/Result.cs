using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Result.BaseType
{
    public class Result
    {
        private string Message { get; set; }
        private bool IsSuccess { get; set; }

        public Result(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }


    }
}
