using CodingPatterns;

List<int> nums = [2, 1, 2, 4, 8, 8];
int ratio = 2;

var count = GeometricSequence.FindTriplets(nums, ratio);
Console.WriteLine(count);
Console.ReadLine();