using BC.Helpers;

namespace BC.CodingPatterns;

/*
Given an array of integers sorted in ascending order and a target value, return any / all pair of numbers in the array that sum to the target. If no pair is found, return an empty array.
*/
public class PairSumSorted {
    public static Result<Pair<int>> FindIndex(int[] nums, int target) {
        if (nums.Length < 2) {
            return Result<Pair<int>>.Failure(Error.InvalidInput());
        }

        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];

            if (sum == target) {
                return Result<Pair<int>>.Success(new(left, right));
            }
            else if (sum > target) {
                right -= 1;
            }
            else {
                left += 1;
            }
        }

        return Result<Pair<int>>.Failure(Error.NotFound());
    }

    public static Result<Pair<int>> FindPair(int[] nums, int target) {
        var result = FindIndex(nums, target);

        if (!result.IsSuccess) {
            return result;
        }

        return Result<Pair<int>>.Success(new(nums[result.Value.X], nums[result.Value.Y]));
    }

    public static Result<List<Pair<int>>> FindIndexes(int[] nums, int target) {
        if (nums.Length < 2) {
            return Result<List<Pair<int>>>.Failure(Error.InvalidInput());
        }

        List<Pair<int>> pairs = [];

        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];

            if (sum == target) {
                var lnum = nums[left];
                var rnum = nums[right];

                if (lnum == rnum) {
                    for (int i = left; i <= right; i++) {
                        for (int j = i + 1; j <= right; j++) {
                            pairs.Add(new(i, j));
                        }
                    }

                    left = right;
                }
                else {
                    int ltemp = left;
                    while (ltemp < right && nums[ltemp] == lnum) {
                        ltemp++;
                    }

                    int rtemp = right;
                    while (rtemp > left && nums[rtemp] == rnum) {
                        rtemp--;
                    }

                    for (int i = left; i < ltemp; i++) {
                        for (int j = right; j > rtemp; j--) {
                            pairs.Add(new(i, j));
                        }
                    }

                    left = ltemp;
                    right = rtemp;
                }
            }
            else if (sum > target) {
                right -= 1;
            }
            else {
                left += 1;
            }
        }

        return Result<List<Pair<int>>>.Success(pairs);
    }

    public static Result<List<Pair<int>>> FindPairs(int[] nums, int target) {
        var result = FindIndexes(nums, target);

        if (!result.IsSuccess) {
            return result;
        }

        List<Pair<int>> pairs = [];
        result.Value?.ForEach(p => pairs.Add(new(nums[p.X], nums[p.Y])));

        return Result<List<Pair<int>>>.Success(pairs);
    }
}