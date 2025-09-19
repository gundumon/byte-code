/*
Given an array of integers sorted in ascending order and a target value, return the indexes of any pair of numbers in the array that sum to the target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.
*/

ValueTuple<int, int>? IndexesThatSumToTarget(int[] nums, int target) {
    var left = 0;
    var right = nums.Length - 1;

    while (left < right) {
        var sum = nums[left] + nums[right];

        // if the sum is smaller, increment the left pointer to increase the sum
        if (sum < target)
            left += 1;
        // if the sum is larger, decrement the right pointer to decrease the sum
        else if (sum > target)
            right -= 1;
        else
            return [left, right];
    }

    return [];
}

var nums1 = [-5, -2, 3, 4, 6];
var tgt1 = 7;
var indexes = IndexesThatSumToTarget(nums1, tgt1);
Console.WriteLine($"{nums1} | {tgt1} -> {indexes}");

nums1 = [1, 1, 1];
tgt1 = 2;
indexes = IndexesThatSumToTarget(nums1, tgt1);
Console.WriteLine($"{nums1} | {tgt1} -> {indexes}");
