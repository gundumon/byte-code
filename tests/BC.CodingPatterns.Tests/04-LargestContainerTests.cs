namespace BC.CodingPatterns.Tests;

public class LargestContainerTests {
    [Theory]
    [InlineData([new int[] { }])]
    [InlineData([new int[] { 1 }])]
    public void Find_InvalidHeights_ReturnsZero(int[] heights) {
        var result = LargestContainer.Find(heights);

        Assert.Equal(0, result);
    }

    public void Find_ValidHeights_ReturnsSizeOfLargestContainer(int[] heights) {

    }
}
