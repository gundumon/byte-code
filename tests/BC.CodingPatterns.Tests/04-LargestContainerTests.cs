namespace BC.CodingPatterns.Tests;

public class LargestContainerTests {
    [Fact]
    public void FindLargestArea_EmptyInput_ReturnsZero() {
        int[] heights = [];

        var result = LargestContainer.FindLargestArea(heights);

        Assert.Equal(0, result);
    }

    [Fact]
    public void FindLargestArea_InputContainsOnlyOneHeight_ReturnsZero() {
        int[] heights = [1];

        var result = LargestContainer.FindLargestArea(heights);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(new int[] { 0, 1, 0 }, 0)]
    [InlineData(new int[] { 3, 3, 3, 3 }, 9)]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { 3, 2, 1 }, 2)]
    [InlineData(new int[] { 2, 7, 8, 3, 7, 6 }, 24)]
    public void FindLargestArea_ValidInput_ReturnsZero(int[] heights, int expected) {
        var result = LargestContainer.FindLargestArea(heights);

        Assert.Equal(expected, result);
    }
}
