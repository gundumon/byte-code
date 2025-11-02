namespace BC.CodingPatterns.Tests;

public class LargestContainerTests {
    [Theory]
    [InlineData([new int[] { }])]
    [InlineData([new int[] { 1 }])]
    public void Find_InvalidHeights_ReturnsZero(int[] heights) {
        var result = LargestContainer.Find(heights);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData([new int[] { 0, 1, 0 }, 0])]
    [InlineData([new int[] { 3, 3, 3, 3 }, 9])]
    [InlineData([new int[] { 1, 2, 3 }, 2])]
    [InlineData([new int[] { 3, 2, 1 }, 2])]
    public void Find_ValidHeights_ReturnsSizeOfLargestContainer(int[] heights, int expectedOutput) {
        var result = LargestContainer.Find(heights);

        Assert.Equal(expectedOutput, result);
    }
}
