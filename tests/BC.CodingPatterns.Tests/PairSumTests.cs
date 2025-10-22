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

    [Fact]
    public void FindAnyPair_InputLengthLessThanTwo_ReturnsNull() {
        int[] nums = [1];
        int target = 5;

        (int, int)? result = PairSum.FindAnyPair(nums, target);

        Assert.Null(result);
    }

    [Fact]
    public void FindAnyPair_InputContainsNoPairs_ReturnsNull() {
        int[] nums = [1, 2, 5];
        int target = 5;

        (int, int)? result = PairSum.FindAnyPair(nums, target);

        Assert.Null(result);
    }

    [Fact]
    public void FindAnyPair_OneMatchingPair_ReturnsPair() {
        int[] nums = [1, 2, 3, 5];
        int target = 5;

        (int a, int b)? result = PairSum.FindAnyPair(nums, target);

        Assert.NotNull(result);
        Assert.Equal(target, result.Value.a + result.Value.b);
    }

    [Fact]
    public void FindAnyPair_MultipleMatchingPairs_ReturnsPair() {
        int[] nums = [1, 2, 3, 4, 5];
        int target = 5;

        (int a, int b)? result = PairSum.FindAnyPair(nums, target);

        Assert.NotNull(result);
        Assert.Equal(target, result.Value.a + result.Value.b);
    }
}
