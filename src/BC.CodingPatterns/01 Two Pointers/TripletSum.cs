namespace CodingPatterns;

/*
Given an array of integers, return all triplets [a, b, c] such that a + b + c = 0 . The solution must not contain duplicate triplets (e.g., [1, 2, 3] and [2, 3, 1] are considered duplicates). If no such triplets are found, return an empty array.
*/
public class TripletSum {
    public static HashSet<Tuple<int, int, int>> FindAllTriplets(int[] nums) {
        var triplets = new HashSet<Tuple<int, int, int>>();
        Array.Sort(nums);

        var targetIndex = 0;
        while (targetIndex < nums.Length) {
            var target = nums[targetIndex];
            var startIndex = targetIndex + 1;
            var temp = nums[startIndex..];
            var pairs = FindPairs(temp, target * -1);
            foreach (var pair in pairs)
                triplets.Add(Tuple.Create(target, pair.Item1, pair.Item2));

            targetIndex += 1;
            while ((targetIndex < nums.Length) && (nums[targetIndex] == target))
                targetIndex += 1;
        }

        return triplets;
    }

    public static HashSet<Tuple<int, int>> FindPairs(int[] nums, int target) {
        var pairs = new HashSet<Tuple<int, int>>();
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
                pairs.Add(Tuple.Create(nums[left], nums[right]));
                left += 1;
                right -= 1;
            }
        }

        return pairs;
    }
}
