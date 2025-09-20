namespace CodingPatterns;

/*
Given an array of integers, return all triplets [a, b, c] such that a + b + c = 0 . The solution must not contain duplicate triplets (e.g., [1, 2, 3] and [2, 3, 1] are considered duplicates). If no such triplets are found, return an empty array.

Example:
    Input: [0, -1, 2, -3, 1]
    Output: [[-3, 1, 2], [-1, 0, 1]]
*/
public class TripleSum {
    public static List<Tuple<int, int, int>> FindAllTriplete(int[] nums) {
        var triplets = new List<Tuple<int, int, int>>();
        Array.Sort(nums);

        var i = 0;
        while (i < nums.Length) {
            var j = i++;
            var temp = nums[j..];
            var result = FindPairs(temp, nums[i] * -1);
            result.ForEach(x => {
                triplets.Add(Tuple.Create(nums[i], x.Item1, x.Item2));
            });
        }

        return [];
    }

    public static List<Tuple<int, int>> FindPairs(int[] nums, int target) {
        var pairs = new List<Tuple<int, int>>();
        var left = 0;
        var right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];

            // if the sum is smaller, increment the left pointer to increase the sum
            if (sum < target) {
                left += 1;
            }
            // if the sum is larger, decrement the right pointer to decrease the sum
            else if (sum > target) {
                right -= 1;
            }
            else {
                pairs.Add(Tuple.Create(left, right));
                left += 1;
                right -= 1;
            }
        }

        return pairs;
    }
}
