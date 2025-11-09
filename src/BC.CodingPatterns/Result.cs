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

    public ErrorType Error { get; }

    public T? Value { get; }

    public static Result<T> Success(T value) {
        return new(true) {
            Value = value
        };
    }

    public static Result<T> Failure() => new(false)
}

public class Test {
    public void Foo() {
        var r = Result<int>.Success(12);
    }
}