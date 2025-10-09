namespace CodingPatterns;

public class LinkedListNode<T>(T value) {
    public T Value { get; } = value;

    public LinkedListNode<T>? Next { get; set; } = null;
}
