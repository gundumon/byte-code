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
}
