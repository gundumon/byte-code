using CodingPatterns;

int[] nums = [-4, -4, -2, 0, 0, 1, 2, 3];

var result = TripletSum.FindAllTriplets(nums);
Console.WriteLine($"[{string.Join(", ", nums)}]");
foreach(var (a, b, c) in result) {
    Console.WriteLine($"[{a}, {b}, {c}]");
}

Console.ReadLine();
