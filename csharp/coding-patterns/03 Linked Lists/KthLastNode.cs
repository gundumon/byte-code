namespace CodingPatterns;

/*
Return the head of a singly linked list after removing the kth node from the end of it

Constraint:
    The linked list contains at least one node
*/
public class KthLastNode {
    public ListNode<int> Remove(ListNode<int> head, int k) {
        // a dummy node to ensure there is a node before 'head' in case we need to remove the head node
        ListNode<int> dummy = new(-1);
        dummy.Next = head;
        ListNode<int> trainer = dummy;
        ListNode<int> leader = dummy;

        // advance leader 'k' steps ahead
        for (var i = 0; i < k; i++) {
            leader = leader.Next;

            if (leader == null) {
                return head;
            }
        }
    }
}
