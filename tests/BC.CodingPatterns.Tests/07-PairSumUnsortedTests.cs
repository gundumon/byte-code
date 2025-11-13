namespace BC.CodingPatterns.Tests;

public class PairSumUnsortedTests {
    [Fact]
    public void FindPairs_InvalidInput_ReturnsNull() {
        int[] nums = [];
        int target = 4;

        var result = PairSumUnsorted.FindPairs(nums, target);

        Assert.Null(result);
    }

    [Fact]
    public void FindPairs_InputLengthLessThanTwo_ReturnsNull() {
        int[] nums = [1];
        int target = 3;

        var result = PairSumUnsorted.FindPairs(nums, target);

        Assert.Null(result);
    }

    [Fact]
    public void FindPairs_PairFound_ReturnsPair() {
        int[] nums = [-1, 3, 4, 2];
        int target = 3;

        var pair = PairSumUnsorted.FindPairs(nums, target);

        Assert.NotNull(pair);
        Assert.Equal((2, 0), pair);
    }
}
