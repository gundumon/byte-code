namespace BC.CodingPatterns.Tests;

public class PairSumUnsortedTests {
    [Fact]
    public void FindIndex_EmptyInput_ReturnsFailure() {
        int[] nums = [];
        int target = 5;

        var result = PairSumUnsorted.FindIndex(nums, target);

        Assert.False(result.IsSuccess);
    }
}
