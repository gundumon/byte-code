namespace CodingPatterns;

/*
Return the head of a singly linked list after removing the kth node from the end of it

Constraint:
    The linked list contains at least one node
*/
public class KthLastNode {
    public ListNode<int> Remove(ListNode<int> head, int k) {
        ListNode<int> dummy = new(-1);
        dummy.Next = head;
        ListNode<int> trainer = dummy;
        ListNode<int> leader = dummy;

        for (var i = 0; i < k; i++) {

        }
    }
}
