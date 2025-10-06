namespace CodingPatterns;

/*
Return the node where two singly linked lists intersect. If the linked lists don't intersect, return null.
*/
public class LinkedListIntersection {
    public static ListNode<int>? FindNode(ListNode<int> headA, ListNode<int> headB) {
        var ptrA = headA;
        var ptrB = headB;

        while (ptrA != ptrB) {
            ptrA = ptrA == null ? headB : ptrA.Next;
            ptrB = ptrB == null ? headA : ptrB.Next;
        }

        return ptrA;
    }
}
