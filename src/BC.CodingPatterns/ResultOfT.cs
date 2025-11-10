namespace BC.CodingPatterns;

public class Result<T> {
    private Result(T value) {
        IsSuccess = true;
        Value = value;
    }

    private Result(ErrorType error) {
        IsSuccess = false;
        Error = error;
    }

    public bool IsSuccess { get; }

    public ErrorType? Error { get; }

    public T? Value { get; }

    public static Result<T> Success(T value) => new(value);

    public static Result<T> Failure(ErrorType error) => new(error);
}
