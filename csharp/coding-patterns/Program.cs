using CodingPatterns;

List<int[]> nums = [[0, 1, 0, 3, 2], [], [0], [1], [0, 0, 0], [1, 3, 2], [1, 1, 1, 0, 0], [0, 0, 1, 1, 1]];
foreach(var num in nums) {
    var result = ShiftZero.Shift(num);
    Console.WriteLine($"[{string.Join(", ", num)}] -> [{string.Join(", ", result)}]");
}

Console.ReadLine();