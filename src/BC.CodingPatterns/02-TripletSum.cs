using BC.Helpers;

namespace BC.CodingPatterns;

/*
Given an array of integers, return all triplets [a, b, c] such that a + b + c = 0 . 
The solution must not contain duplicate triplets (e.g., [1, 2, 3] and [2, 3, 1] are considered duplicates). 
If no such triplets are found, return an empty array.
*/
public class TripletSum {
    public static Result<List<Triplet<int>>> FindAllTriplets(int[] nums) {
        if (nums.Length < 3) {
            return Result<List<Triplet<int>>>.Failure(Error.InvalidInput());
        }

        List<Triplet<int>> triplets = [];

        Array.Sort(nums);

        foreach (int i in Enumerable.Range(0, nums.Length - 1)) {
            if (nums[i] > 0) {
                break;
            }

            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            var rindex = i + 1;
            var pairs = FindPairs(nums[rindex..], -nums[i]);

            pairs.ForEach(p => triplets.Add(new(nums[i], p.X, p.Y)));
        }

        return Result<List<Triplet<int>>>.Success(triplets);
    }

    private static List<Pair<int>> FindPairs(int[] nums, int target) {
        if (nums.Length < 2) {
            return [];
        }

        List<Pair<int>> pairs = [];

        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];

            if (sum == target) {
                pairs.Add(new(nums[left], nums[right]));

                left += 1;
                while (left < right && nums[left] == nums[left - 1]) {
                    left += 1;
                }
            }
            else if (sum > target) {
                right -= 1;
            }
            else {
                left += 1;
            }
        }

        return pairs;
    }
}