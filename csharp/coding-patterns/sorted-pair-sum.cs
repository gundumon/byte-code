/*
Given an array of integers sorted in ascending order and a target value, return the indexes of any pair of numbers in the array that sum to the target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.
*/

ValueTuple<int, int>? IndexesThatSumToTarget(int[] nums, int target) {
    var left = 0;
    var right = nums.Length - 1;

    while (left < right) {
        var sum = nums[left] + nums[right];
        if (sum == target) {
            return (left, right);
        }
    }

    return null;
}

var indexes = IndexesThatSumToTarget([-5, -2, 3, 4, 6], 7);
Console.WriteLine(indexes);
