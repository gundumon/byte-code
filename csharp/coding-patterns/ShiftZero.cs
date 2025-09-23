namespace CodingPatterns;

public class ShiftZero {
    public static int[] Shift(int[] nums) {
        int left = 0;
        int right = 0;

        while (right < nums.Length) {
            if ((nums[right] != 0) && (right != left)) {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left += 1;
            }
            
            right += 1;
        }

        return nums;
    }
}
