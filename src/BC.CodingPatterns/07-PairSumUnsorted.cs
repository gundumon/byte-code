using BC.Helpers;

namespace BC.CodingPatterns;

/*
Given an array of integers, return the indexes of any two numbers that add up to a target. 
The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.

Constraint: The same index cannot be used twice in the result
*/
public class PairSumUnsorted {
    public static Result<Pair<int>> FindIndex(int[] nums, int target) {
        if (nums.Length < 2) {
            return Result<Pair<int>>.Failure(Error.InvalidInput());
        }

        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];

            if (map.ContainsKey(target - num)) {
                return Result<Pair<int>>.Success(new(map[target - num], i));
            }

            map.Add(num, i);
        }

        return Result<Pair<int>>.Failure(Error.NotFound());
    }

    public static Result<Pair<int>> FindPair(int[] nums, int target) {
        if (nums.Length < 2) {
            return Result<Pair<int>>.Failure(Error.InvalidInput());
        }

        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];

            if (map.ContainsKey(target - num)) {
                return Result<Pair<int>>.Success(new(target - num, num));
            }

            map.Add(num, i);
        }

        return Result<Pair<int>>.Failure(Error.NotFound());
    }

    public static Result<List<Pair<int>>> FindIndexes(int[] nums, int target) {
        if (nums.Length < 2) {
            return Result<List<Pair<int>>>.Failure(Error.InvalidInput());
        }

        Dictionary<int, int> map = [];
        HashSet<(int a, int b)> set = [];

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];

            if (map.ContainsKey(target - num)) {
                set.Add((map[target - num], i));
            }

            map.Add(num, i);
        }

        return Result<List<Pair<int>>>.Success([.. set.Select(x => new Pair<int>(x.a, x.b))]);
    }

    public static Result<List<Pair<int>>> FindPairs(int[] nums, int target) {
        if (nums.Length < 2) {
            return Result<List<Pair<int>>>.Failure(Error.InvalidInput());
        }

        Dictionary<int, int> map = [];
        HashSet<(int a, int b)> set = [];

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];

            if (map.ContainsKey(target - num)) {
                set.Add((target - num, num));
            }

            map.Add(num, i);
        }

        return Result<List<Pair<int>>>.Success([.. set.Select(x => new Pair<int>(x.a, x.b))]);
    }
}
