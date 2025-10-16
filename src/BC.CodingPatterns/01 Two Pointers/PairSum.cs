namespace CodingPatterns;

/*
Given an array of integers sorted in ascending order and a target value, return the indexes of any pair of numbers in the array that sum to the target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.

Example:
    int[] nums = [-5, -2, 1, 3, 4, 6]
    int target = 7
    output: [2, 3]
*/
public class PairSum {
    public static List<int[]> FindAnyPair(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return [];

        List<int[]> result = [];
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];
            if (sum == target) {
                result.Add([left, right]);
                break;
            }
            else if (sum < target) {
                left += 1;
            }
            else {
                right -= 1;
            }
        }

        return result;
    }

    public static List<int[]> FindAllPairs(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return [];

        List<int[]> result = [];
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];

            if (sum == target) {
                int leftValue = nums[left];
                int rightValue = nums[right];

                if (leftValue != rightValue) {
                    int tempL = left;

                    while (tempL < right && nums[tempL] == leftValue) {
                        tempL++;
                    }
                    
                    int countL = tempL - left;

                    int tempR = right;

                    while (tempR > left && nums[tempR] == rightValue) {
                        tempR--;
                    }
                    
                    int countR = right - tempR;

                    for (int i = 0; i < countL; i++) {
                        for (int j = 0; j < countR; j++) {
                            result.Add([left + i, right - j]);
                        }
                    }

                    left = tempL;
                    right = tempR;
                }
                else {
                    int N = right - left + 1;

                    for (int i = 0; i < N; i++) {
                        for (int j = i + 1; j < N; j++) {
                            result.Add([left + i, left + j]);
                        }
                    }

                    left = right;
                }
            }
            else if (sum < target) {
                left += 1;
            }
            else {
                right -= 1;
            }
        }

        return result;
    }
}