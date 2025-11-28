namespace BC.CodingPatterns;

/*
Given an array of integers, modify the array in place to move all zeros to the end while maintaining the relative order of non-zero elements.
*/
public class ShiftZeroes {
    public static int[] ShiftToEnd(int[] nums) {
        if (nums.Length < 2) {
            return nums;
        }

        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] != 0) {
                if (right != left) {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                }

                left += 1;
            }
        }

        return nums;
    }
}
