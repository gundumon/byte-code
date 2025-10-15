using CodingPatterns;

int[] nums = [1, 2, 2, 3, 3, 4, 5];
int target = 5;

var result = PairSum.FindAnyPair(nums, target);
Console.WriteLine($"[{string.Join(", ", nums)}] => {target}");
Console.WriteLine($"[{result?.num1}, {result?.num2}]");
Console.ReadLine();
