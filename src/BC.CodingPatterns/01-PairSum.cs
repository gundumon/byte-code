namespace BC.CodingPatterns;

/*
Given an array of integers sorted in ascending order and a target value, return any / all pair of numbers in the array that sum to the target. If no pair is found, return an empty array.
*/
public class PairSum {
    public static (int a, int b)? FindAnyPair(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return null;

        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];

            if (sum == target) {
                return (nums[left], nums[right]);
            }
            else if (sum < target) {
                left += 1;
            }
            else {
                right -= 1;
            }
        }

        return null;
    }

    public static List<(int a, int b)> FindAllPairs(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return [];

        List<(int, int)> result = [];
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            var sum = nums[left] + nums[right];

            if (sum == target) {
                int leftNum = nums[left];
                int rightNum = nums[right];

                if (leftNum == rightNum) {
                    var count = right - left + 1;

                    for (var i = 0; i < count; i ++) {
                        for (var j = i + 1; j < count; j++) {
                            result.Add((nums[left + i], nums[left + j]));
                        }
                    }

                    left = right;
                }
                else {
                    int tempL = left;

                    while (tempL < right && nums[tempL] == leftNum) {
                        tempL++;
                    }

                    int countL = tempL - left;

                    int tempR = right;

                    while (tempR > left && nums[tempR] == rightNum) {
                        tempR--;
                    }

                    int countR = right - tempR;

                    for (int i = 0; i < countL; i++) {
                        for (int j = 0; j < countR; j++) {
                            result.Add((nums[left + i], nums[right - j]));
                        }
                    }

                    left = tempL;
                    right = tempR;
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