using CodingPatterns;

ListNode<int> a = new(1);
ListNode<int> b = new(3);
ListNode<int> c = new(4);
ListNode<int> d = new(8);
ListNode<int> e = new(7);
ListNode<int> f = new(2);
ListNode<int> g = new(6);
ListNode<int> h = new(4);

a.Next = b;
b.Next = c;
c.Next = d;
d.Next = e;
e.Next = f;
g.Next = h;
h.Next = d;

var result = LinkedListIntersection.FindNode(a, g);
Console.ReadLine();
