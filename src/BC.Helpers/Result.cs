namespace BC.Helpers;

public class Result {
    protected Result(bool isSuccess, Error? error) {
        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }

    public Error? Error { get; }

    public static Result Success() => new(true, null);
}
