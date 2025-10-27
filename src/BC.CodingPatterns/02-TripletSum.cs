namespace BC.CodingPatterns;

/*
Given an array of integers, return all triplets [a, b, c] such that a + b + c = 0 . The solution must not contain duplicate triplets (e.g., [1, 2, 3] and [2, 3, 1] are considered duplicates). If no such triplets are found, return an empty array.
*/
public class TripletSum {
    public static HashSet<(int a, int b, int c)> FindAllTriplets(int[] nums) {
        if (nums.Length < 3) {
            return [];
        }

        var triplets = new HashSet<(int, int, int)>();
        Array.Sort(nums);

        var targetIndex = 0;
        while (targetIndex < nums.Length) {
            var target = nums[targetIndex];
            var startIndex = targetIndex + 1;
            var temp = nums[startIndex..];
            
            var pairs = PairSum.FindAllPairs(temp, target * -1);

            foreach (var (a, b) in pairs) {
                triplets.Add((target, a, b));
            }

            targetIndex += 1;
            while ((targetIndex < nums.Length) && (nums[targetIndex] == target))
                targetIndex += 1;
        }

        return triplets;
    }
}