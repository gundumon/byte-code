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


    }
}
