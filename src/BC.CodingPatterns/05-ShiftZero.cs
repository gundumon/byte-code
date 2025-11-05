namespace BC.CodingPatterns;

/*
Given an array of integers, modify the array in place to move all zeros to the end while maintaining the relative order of non-zero elements.
*/
public class ShiftZero {
    public static int[] ShiftToEnd(int[] nums) {
        if (nums.Length < 2) {
            return nums;
        }

        int left = 0;
        int right = 0;

        while (right < nums.Length) {
            if (nums[right] != 0) {
                if (right != left) {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                }

                left += 1;
            }

            right += 1;
        }

        return nums;
    }
}
