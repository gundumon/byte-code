namespace BC.CodingPatterns;

/*
You are given an array of numbers, each representing the height of a vertical line on a graph. 
A container can be formed with any pair of these lines, along with the x-axis of the graph. 
Return the amount of water which the largest container can hold.
*/
public class LargestContainer {
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

            if (heights[left] == heights[right]) {
                left += 1;
                right -= 1;
            }
            else if (heights[left] < heights[right]) {
                left += 1;
            }
            else {
                right -= 1;
            }
        }

        return largest_area;
    }
}
