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

    public static ListNode<int>? ReverseRecursive(ListNode<int> head) {
        // base cases
        if (head is null || head.Next is null) {
            return head;
        }

        // recursively reverse the sublist starting at the next node
        var new_head = ReverseRecursive(head.Next);

        // connect the reversed sublist to the head node to fully reverse the entire linked list
        head.Next.Next = head;
        head.Next = null;

        return new_head;
    }
}
