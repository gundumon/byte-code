namespace BC.CodingPatterns.Tests;

public class PairSumUnsortedTests {
    [Fact]
    public void FindPairs_InvalidInput_ReturnsNull() {
        int[] nums = [];

        var result = PairSumUnsorted.FindPairs(nums, 10);

        Assert.Null(result);
    }
}
