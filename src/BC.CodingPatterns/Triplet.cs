namespace BC.CodingPatterns;

public readonly struct Triplet<T>(T x, T y, T z) {
    public T X { get; init; } = x;

    public T Y { get; init; } = y;

    public T Z { get; init; } = z;
}
