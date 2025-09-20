namespace CodingPatterns;

/*
Given an array of integers, return all triplets [a, b, c] such that a + b + c = 0 . The solution must not contain duplicate triplets (e.g., [1, 2, 3] and [2, 3, 1] are considered duplicates). If no such triplets are found, return an empty array.

Example:
    Input: [0, -1, 2, -3, 1]
    Output: [[-3, 1, 2], [-1, 0, 1]]
*/
public class TripleSum {
    List<Tuple<int, int, int>> FindAllTriplete(int[] nums) {
        Array.Sort(nums);

        var i = 0;
        while (i < nums.Length) {
            var j = i++;
            var temp = nums[j..];
            var result = FindPairs(temp, nums[i] * -1);
        }

        return [];
    }

    List<Tuple<int, int>> FindPairs(int[] nums, int target) {
        var pairs = new List<Tuple<int, int>>();
        var left = 0;
        var right = nums.Length - 1;




        return [];
    }
}
