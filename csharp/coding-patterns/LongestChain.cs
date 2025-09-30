namespace CodingPatterns;

/*
Find the longest chain of consecutive numbers in an array. Two numbers are consecutive if they have a difference of 1

Example:
    Input: [1, 6, 2, 5, 8, 7, 10, 3]
    Output: 4 (The longest chain of consecutive numbers is 5, 6, 7, 8)
*/
public class LongestChain {
    public static int FindChain(List<int> nums) {
        int longestChain = 0;
        HashSet<int> numSet = [.. nums];

        foreach(var num in numSet) {
            if (!numSet.Contains(num - 1)) {
                int currentNum = num;
                int currentChain = 1;
            }
        }

        return longestChain;
    }
}
