namespace BC.Helpers;

public class Error(ErrorType errorType, string message) {
    public ErrorType ErrorType { get; } = errorType;

    public string Message { get; } = message;

    public static Error Empty() => new(ErrorType.Empty, string.Empty);

    public static Error NotFound(string message) => new(ErrorType.NotFound, message);

    public static Error InvalidInput(string message) => new(ErrorType.InvalidInput, message);
}
