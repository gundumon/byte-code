namespace BC.Helpers;

public class Result {
    protected Result(bool isSuccess, Error error) {
        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }

    public Error Error { get; }

    public static Result Success() => new(true, Error.Empty());

    public static Result Failure(Error error) => new(false, error);
}

public class Result<T> : Result {
    private readonly T? _value;

    private Result(T value) : base(true, Error.Empty()) {
        _value = value;
    }

    private Result(Error error) : base(false, error) {
        _value = default;
    }

    public T? Value {
        get => IsSuccess ? _value! : throw new InvalidOperationException("Cannot access value when IsSuccess is false.");
    }

    public static Result<T> Success(T value) => new(value);

    public static new Result<T> Failure(Error error) => new(error);
}