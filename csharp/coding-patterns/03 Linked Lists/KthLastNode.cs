namespace CodingPatterns;

/*
Return the head of a singly linked list after removing the kth node from the end of it

Constraint:
    The linked list contains at least one node
*/
public class KthLastNode {
    public LinkedListNode<int> Remove(LinkedListNode<int> head, int k) {
        // a dummy node to ensure there is a node before 'head' in case we need to remove the head node
        LinkedListNode<int> dummy = new(-1);
        dummy.Next = head;
        LinkedListNode<int> trailer = dummy;
        LinkedListNode<int>? leader = dummy;

        // advance leader 'k' steps ahead
        for (var i = 0; i < k; i++) {
            leader = leader.Next;

            if (leader == null) {
                return head;
            }
        }

        // move 'leader' to the end of the linked list, keeping 'trailer' k nodes behind
        while (leader != null) {
            leader = leader.Next;
            trailer = trailer.Next;
        }

        // remove the kth node from the end
        trailer.Next = trailer.Next.Next;

        return dummy.Next;
    }
}
