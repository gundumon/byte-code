namespace CodingPatterns;

/*
Design and implement a data structure for the Least Recently Used (LRU) cache that supports the following operations:
1. LRUCache(capacity: int): Initialize an LRU cache with the specified capacity
2. get(key: int) -> int: Return the value associated with a key. Return -1 if the key doesn't exist
3. put(key: int, value: int) -> None: Add a key and its value to the cache. If adding the key would result in the cache exceeding its size capacity, evict the least recently used element. If the key already exists in the cache, update its value

Constraints:
    1. All keys and values are positive integers
    2. The cache capacity is positive
*/
public class LRUCache {
    private readonly int maxCapacity;
    private Dictionary<int, DoublyLinkedListNode<int>> hashMap = [];
    private DoublyLinkedListNode<int> head = new(-1, -1);
    private DoublyLinkedListNode<int> tail = new(-1, -1);

    public LRUCache(int capacity) {
        maxCapacity = capacity;
        head.Next = tail;
        tail.Prev = head;
    }

    public int Get(int key) {
        if (!hashMap.ContainsKey(key)) {
            return -1;
        }

        var node = hashMap[key];
        RemoveNode(node);
        AddToTail(node);

        return node.Value;
    }

    public void Put(int key, int value) {
        if (hashMap.ContainsKey(key)) {
            RemoveNode(hashMap[key]);
        }

        var node = new DoublyLinkedListNode<int>(key, value);
        hashMap[key] = node;

        if (hashMap.Count > maxCapacity) {
            var lru = head.Next;
            hashMap.Remove(lru.Key);
            RemoveNode(lru);
        }

        AddToTail(node);
    }

    public void AddToTail(DoublyLinkedListNode<int> node) {
        var prevNode = tail.Prev;

        node.Prev = prevNode;
        node.Next = tail;

        prevNode.Next = node;
        tail.Prev = node;
    }

    public void RemoveNode(DoublyLinkedListNode<int> node) {
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }
}
