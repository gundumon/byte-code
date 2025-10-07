namespace CodingPatterns;

public class DoublyLinkedListNode<T>(int key, T value) {
    public int Key { get; init; } = key;

    public T Value { get; init; } = value;

    public DoublyLinkedListNode<T>? Next { get; set; }

    public DoublyLinkedListNode<T>? Prev { get; set; }
}
