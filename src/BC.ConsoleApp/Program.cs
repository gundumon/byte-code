using CodingPatterns;

int[] nums = [2, 4];
int target = 5;

var result = PairSum.FindAnyPair(nums, target);
Console.WriteLine($"[{string.Join(", ", nums)}] => {target}");
result.ForEach(x => Console.WriteLine($"[{x[0]}, {x[1]}] => [{nums[x[0]]}, {nums[x[1]]}]"));

result = PairSum.FindAllPairs(nums, target);
Console.WriteLine($"[{string.Join(", ", nums)}] => {target}");
result.ForEach(x => Console.WriteLine($"[{x[0]}, {x[1]}] => [{nums[x[0]]}, {nums[x[1]]}]"));

Console.ReadLine();
