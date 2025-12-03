namespace BC.CodingPatterns.Tests;

public class PairSumUnsortedTests {
    [Fact]
    public void FindIndex_EmptyInput_ReturnsFailure() {
        int[] nums = [];
        int target = 5;

        var result = PairSumUnsorted.FindIndex(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Fact]
    public void FindIndex_InputLengthLessThanTwo_ReturnsFailure() {
        int[] nums = [1];
        int target = 5;

        var result = PairSumUnsorted.FindIndex(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] {0, 2, 4}, 5])]
    public void FindIndex_NoPairs_ReturnsFailure(int[] nums, int target) {
        var result = PairSumUnsorted.FindIndex(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
}
