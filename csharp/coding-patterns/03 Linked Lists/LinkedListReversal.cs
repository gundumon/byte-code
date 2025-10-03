namespace CodingPatterns;

/*
Reverse a singly linked list
*/
public class LinkedListReversal {
    public static ListNode<int>? Reverse(ListNode<int> head) {
        ListNode<int>? currNode = head;
        ListNode<int>? prevNode = null;
        
        // reverse the direction of each node's pointer until 'currNode' is null
        while (currNode != null) {
            var nextNode = currNode.Next;
            currNode.Next = prevNode;
            
            prevNode = currNode;
            currNode = nextNode;
        }

        // 'prevNode' will be pointing at the head of the reversed linked list
        return prevNode;
    }
}
