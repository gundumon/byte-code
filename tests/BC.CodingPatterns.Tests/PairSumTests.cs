using CodingPatterns;

namespace BC.CodingPatterns.Tests;

public class PairSumTests {
    [Fact]
    public void FindAnyPair_EmptyInput_ReturnsNull() {
        int[] nums = [];
        int target = 5;

        (int, int)? result = PairSum.FindAnyPair(nums, target);

        Assert.Null(result);
    }
}
