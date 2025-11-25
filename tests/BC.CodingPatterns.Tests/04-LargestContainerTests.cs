namespace BC.CodingPatterns.Tests;

public class LargestContainerTests {
    public static int FindLargestArea(int[] heights) {
        if (heights.Length < 2) {
            return 0;
        }

        int left = 0;
        int right = heights.Length - 1;
        int largest_area = 0;

        while (left < right) {
            var area = Math.Min(heights[left], heights[right]) * (right - left);
            largest_area = Math.Max(largest_area, area);
        }

        return largest_area;
    }
}
