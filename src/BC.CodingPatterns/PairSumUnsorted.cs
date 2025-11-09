namespace CodingPatterns;

/*
Given an array of integers, return the indexes of any two numbers that add up to a target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.

Constraint: The same index cannot be used twice in the result

Example:
    Input: nums = [-1, 3, 4, 2], target = 3
    Output: [0, 2]
*/
public class PairSumUnsorted {
    public static int[] FindPairs(int[] nums, int target) {
        Dictionary<int, int> hashmap = [];

        for(int i = 0; i < nums.Length; i++) {
            int x = nums[i];
            if (hashmap.ContainsKey(target - x)) {
                return [i, hashmap[target - x]];
            }

            hashmap[x] = i;
        }

        return [];
    }
}
