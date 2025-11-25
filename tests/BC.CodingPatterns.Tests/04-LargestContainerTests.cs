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
    public void FindLargestArea_ValidInput_ReturnsZero(int[] heights, int expected) {
        var result = LargestContainer.FindLargestArea(heights);

        Assert.Equal(expected, result);
    }
}
