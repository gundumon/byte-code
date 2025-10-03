using CodingPatterns;

ListNode<int> a = new ListNode<int>(1);
ListNode<int> b = new ListNode<int>(2);
ListNode<int> c = new ListNode<int>(4);
ListNode<int> d = new ListNode<int>(7);
ListNode<int> e = new ListNode<int>(3);

a.Next = b;
b.Next = c;
c.Next = d;
d.Next = e;

var result = LinkedListReversal.Reverse(a);
Console.ReadLine();