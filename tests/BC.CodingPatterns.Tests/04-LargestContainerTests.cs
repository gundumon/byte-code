namespace BC.CodingPatterns.Tests;

public class LargestContainerTests {
    [Fact]
    public void FindLargestArea__EmptyInput_ReturnsZero() {
        int[] heights = [];

        var result = LargestContainer.FindLargestArea(heights);

        Assert.Equal(0, result);
    }
}
