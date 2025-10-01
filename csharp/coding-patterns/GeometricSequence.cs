namespace CodingPatterns;

/*
Given an array of integers and a common ratio r, find all triplets of indexes (i, j, k) that follow a geometric sequence for i < j < k. It's possible to encounter duplicate triplets in the array.

Example:
    Input: [2, 1, 2, 4, 8, 8]
    Ration: 2
    Output: 5
*/
public class GeometricSequence {
    public static int FindTriplets(List<int> nums, int ratio) {
        Dictionary<int, int> leftDict = [];
        Dictionary<int, int> rightDict = [];
        int count = 0;

        // populate the right dictionary with the frequency of each element in the array
        foreach(var num in nums) {
            rightDict.Add(num, rightDict.GetValueOrDefault(num, 0) + 1);
        }

        // search for geometric triplets that have x as the center
        foreach(var num in nums) {
            // decrement the frequency of num in right dictionary since num is now being processed and is no loger to the right
            rightDict[num] = rightDict[num] - 1;

            if (num % ratio == 0) {
                count += leftDict.GetValueOrDefault(num / ratio, 0) * rightDict.GetValueOrDefault(num * ratio, 0);
            }

            leftDict.Add(num, leftDict.GetValueOrDefault(num, 0) + 1);
        }
    }
}
