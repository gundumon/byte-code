namespace BC.CodingPatterns;

/*
Given an array of integers, return the indexes of any two numbers that add up to a target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.

Constraint: The same index cannot be used twice in the result
*/
public class PairSumUnsorted {
    public static (int a, int b)? FindPairs(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return null;

        Dictionary<int, int> hashmap = [];

        for(int i = 0; i < nums.Length; i++) {
            int x = nums[i];

            if (hashmap.ContainsKey(target - x)) {
                return (i, hashmap[target - x]);
            }

            hashmap[x] = i;
        }

        return null;
    }
}
