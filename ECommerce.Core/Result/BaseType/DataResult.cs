namespace ECommerce.Core.Result.BaseType;

public class DataResult<T> : Result
{
    public T Data { get; set; }
    public DataResult(string message, T data, bool isSuccess) : base(message, isSuccess)
    {
        Data = data;
    }

    public DataResult(T data, bool isSuccess) : base(isSuccess)
    {
        Data = data;
    }
    public DataResult(string message,bool isSuccess) : base(message,isSuccess)
    {
    }
}

