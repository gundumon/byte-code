namespace CodingPatterns;

/*
Reverse a singly linked list
*/
public class LinkedListReversal {
    public static LinkedListNode<int> Reverse(LinkedListNode<int> head) {
        LinkedListNode<int> currNode = head;
        LinkedListNode<int> prevNode = null;

        while (currNode != null) {
            var nextNode = currNode.Next;
            currNode.Next = prevNode;
            
            prevNode = currNode;
            currNode = nextNode;
        }
    }
}
