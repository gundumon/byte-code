namespace CodingPatterns;

/*
Reverse a singly linked list
*/
public class LinkedListReversal {
    public static LinkedList<int>? Reverse(LinkedList<int> linkedList) {
        if (linkedList is null || linkedList.Count == 0)
            return linkedList;

        LinkedListNode<int> currNode = linkedList.First!;
        LinkedListNode<int> prevNode = null;

        // reverse the direction of each node's pointer until 'currNode' is null
        while (currNode != null) {
            var nextNode = currNode.Next;
            linkedList.AddBefore(currNode, prevNode);
            
            prevNode = currNode;
            currNode = nextNode;
        }

        // 'prevNode' will be pointing at the head of the reversed linked list
        return linkedList;
    }
}
