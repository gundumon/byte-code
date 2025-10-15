namespace CodingPatterns;

/*
Given an array of integers sorted in ascending order and a target value, return the indexes of any pair of numbers in the array that sum to the target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.

Example:
    int[] nums = [-5, -2, 1, 3, 4, 6]
    int target = 7
    output: [2, 3]
*/
public class PairSum {
    public static List<int[]> FindAnyPair(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return [];

        List<int[]> result = [];
        int leftPtr = 0;
        int rightPtr = nums.Length - 1;

        while (leftPtr < rightPtr) {
            var sum = nums[leftPtr] + nums[rightPtr];
            if (sum == target) {
                result.Add([leftPtr, rightPtr]);
                break;
            }
            else if (sum < target) {
                leftPtr += 1;
            }
            else {
                rightPtr -= 1;
            }
        }

        return result;
    }
}