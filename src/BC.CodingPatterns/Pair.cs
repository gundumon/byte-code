namespace BC.CodingPatterns;

public readonly struct Pair<T>(T x, T y) {
    public T X { get; init; } = x;

    public T Y { get; init; } = y;
}
