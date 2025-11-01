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

    [Fact]
    public void FindAllPairs_EmptyInput_ReturnsEmpty() {
        int[] nums = [];
        int target = 5;

        List<(int, int)> result = PairSum.FindAllPairs(nums, target);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void FindAllPairs_InputLengthLessThanTwo_ReturnsEmpty() {
        int[] nums = [3];
        int target = 5;

        List<(int, int)> result = PairSum.FindAllPairs(nums, target);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Theory]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 2, 4 }, 5)]
    public void FindAllPairs_NoMatchingPair_ReturnsEmpty(int[] nums, int target) {
        List<(int, int)> result = PairSum.FindAllPairs(nums, target);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Theory]
    [InlineData([new int[] { 2, 3 }, 5, 1])]
    [InlineData([new int[] { 1, 1, 1 }, 2, 3])]
    [InlineData([new int[] { 2, 2, 3 }, 5, 2])]
    [InlineData([new int[] { -1, 2, 3 }, 2, 1])]
    [InlineData([new int[] { -3, -2, -1 }, -5, 1])]
    [InlineData([new int[] { 1, 2, 3, 5 }, 5, 1])]
    [InlineData([new int[] { -5, -2, 2, 3, 4, 5, 9 }, 7, 3])]
    public void FindAllPairs_MatchingPairs_ReturnsAllPairs(int[] nums, int target, int expectedCount) {
        List<(int, int)> result = PairSum.FindAllPairs(nums, target);

        Assert.NotEmpty(result);
        Assert.Equal(expectedCount, result.Count);
        Assert.All(result, (x) => target.Equals(x.Item1 + x.Item2));
    }
}
