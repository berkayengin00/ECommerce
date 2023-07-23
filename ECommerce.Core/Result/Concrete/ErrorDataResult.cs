using ECommerce.Core.Result.BaseType;

namespace ECommerce.Core.Result.Concrete;

public class ErrorDataResult<T> : DataResult<T>
{


    public ErrorDataResult(T data) : base(data, false)
    {
    }

    public ErrorDataResult(string message, T data) : base(message, data, false)
    {
    }
}