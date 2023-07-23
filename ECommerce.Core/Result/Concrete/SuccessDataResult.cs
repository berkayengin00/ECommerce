using ECommerce.Core.Result.BaseType;

namespace ECommerce.Core.Result.Concrete;

public class SuccessDataResult<T> : DataResult<T>
{
    public SuccessDataResult(string message, T data) : base(message, data, true)
    {
    }

    public SuccessDataResult(T data) : base(data, true)
    {
    }
}