namespace CodingPatterns;

/*
You are given an array of numbers, each representing the height of a vertical line on a graph. A container can be formed with any pair of these lines, along with the x-axis of the graph. Return the amount of water which the largest container can hold.
*/
public class LargestContainer {
    public static int FindLargest(int[] heights) {
        int max_water = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {
            // calculate the water contained between the current pair of lines
            var water = Math.Min(heights[left], heights[right]) * (right - left);
            max_water = Math.Max(max_water, water);

            // move the pointers inward, always moving the pointer at the shorter line
            // if both lines have the same height, move both pointers inward
            if (heights[left] < heights[right]) {

            }
        }

        return max_water;
    }
}
