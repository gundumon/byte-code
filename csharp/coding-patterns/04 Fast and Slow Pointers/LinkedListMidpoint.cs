namespace CodingPatterns;

/*
Given a singly linked list, find and return its middle node. If there are two middle nodes, return the second one.

Constraints:
    1. The linked list contains at least one node
    2. The linked list contains unique values
*/
public class LinkedListMidpoint {
    public ListNode<int>? Find(ListNode<int> head) {
        ListNode<int>? fast = head;
        ListNode<int>? slow = head;

        while (fast != null && fast.Next != null) {
            slow = slow?.Next;
            fast = fast.Next.Next;
        }

        return slow;
    }
}
