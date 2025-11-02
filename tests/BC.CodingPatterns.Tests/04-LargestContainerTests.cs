namespace BC.CodingPatterns.Tests;

public class LargestContainerTests {
    [Theory]
    [InlineData([new int[] { }])]
    public void Find_InvalidLength_ReturnsZero(int[] heights) {
        var result = LargestContainer.Find(heights);

        Assert.Equal(0, result);
    }
}
