
using CodingPatterns;

int[] nums = [-1, 3, 4, 2];
int target = 3;

var result = UnsortedPairSum.FindPairs(nums, target);
Console.WriteLine($"[{string.Join(", ", nums)}] : {target} => [{string.Join(", ", result)}]");
Console.ReadLine();