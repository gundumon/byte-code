namespace CodingPatterns;

public class ListNode<T>(T value) {
    public T Value { get; } = value;

    public ListNode<T>? Next { get; set; } = null;
}
