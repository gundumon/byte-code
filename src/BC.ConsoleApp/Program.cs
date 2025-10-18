using CodingPatterns;

int[] nums = [0, -1, 2, -3, 1];

var result = TripletSum.FindAllTriplets(nums);
Console.WriteLine($"[{string.Join(", ", nums)}]");
foreach(var (a, b, c) in result) {
    Console.WriteLine($"[{a}, {b}, {c}]");
}

Console.ReadLine();
