using CodingPatterns;

ListNode<int> a = new(1);
ListNode<int> b = new(2);
ListNode<int> c = new(4);
ListNode<int> d = new(7);
ListNode<int> e = new(3);

a.Next = b;
b.Next = c;
c.Next = d;
d.Next = e;