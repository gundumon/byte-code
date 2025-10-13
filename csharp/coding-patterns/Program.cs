using CodingPatterns;

ListNode<int> a = new(1);
ListNode<int> b = new(2);
ListNode<int> c = new(4);
ListNode<int> d = new(7);
ListNode<int> e = new(3);
ListNode<int> f = new(5);

a.Next = b;
b.Next = c;
c.Next = d;
d.Next = e;
e.Next = f;

var midPoint = LinkedListMidpoint.Find(a);
Console.WriteLine(midPoint?.Value);
Console.ReadLine();