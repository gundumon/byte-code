namespace CodingPatterns;

/*
Given an array of integers sorted in ascending order and a target value, return the indexes of any / all pair of numbers in the array that sum to the target. The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.
*/
public class PairSum {
    public static List<int[]> FindAnyPair(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return [];

        List<int[]> result = [];
        int leftPtr = 0;
        int rightPtr = nums.Length - 1;

        while (leftPtr < rightPtr) {
            var sum = nums[leftPtr] + nums[rightPtr];
            if (sum == target) {
                result.Add([leftPtr, rightPtr]);
                break;
            }
            else if (sum < target) {
                leftPtr += 1;
            }
            else {
                rightPtr -= 1;
            }
        }

        return result;
    }

    public static List<int[]> FindAllPairs(int[] nums, int target) {
        if (nums == null || nums.Length < 2)
            return [];

        List<int[]> result = [];
        int leftPtr = 0;
        int rightPtr = nums.Length - 1;

        while (leftPtr < rightPtr) {
            var sum = nums[leftPtr] + nums[rightPtr];

            if (sum == target) {
                int leftNum = nums[leftPtr];
                int rightNum = nums[rightPtr];

                if (leftNum == rightNum) {
                    var count = rightPtr - leftPtr + 1;

                    for (var i = 0; i < count; i ++) {
                        for (var j = i + 1; j < count; j++) {
                            result.Add([leftPtr + i, leftPtr + j]);
                        }
                    }
                }
                else {
                    int tempL = leftPtr;

                    while (tempL < rightPtr && nums[tempL] == leftNum) {
                        tempL++;
                    }

                    int countL = tempL - leftPtr;

                    int tempR = rightPtr;

                    while (tempR > leftPtr && nums[tempR] == rightNum) {
                        tempR--;
                    }

                    int countR = rightPtr - tempR;

                    for (int i = 0; i < countL; i++) {
                        for (int j = 0; j < countR; j++) {
                            result.Add([leftPtr + i, rightPtr - j]);
                        }
                    }

                    leftPtr = tempL;
                    rightPtr = tempR;
                }
            }
            else if (sum < target) {
                leftPtr += 1;
            }
            else {
                rightPtr -= 1;
            }
        }

        return result;
    }
}