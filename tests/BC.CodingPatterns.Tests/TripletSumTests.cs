namespace BC.CodingPatterns.Tests;

public class TripletSumTests {
    [Fact]
    public void FindAllTriplets_EmptyInput_ReturnsEmpty() {
        int[] nums = [];

        HashSet<(int a, int b, int c)> result = TripletSum.FindAllTriplets(nums);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void FindAllTriplets_InputLengthLessThanThree_ReturnsEmpty() {
        int[] nums = [];

        HashSet<(int a, int b, int c)> result = TripletSum.FindAllTriplets(nums);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Theory]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 2, 4 }, 5)]
    public void FindAllTriplets_NoMatchingPair_ReturnsEmpty(int[] nums, int target) {
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
    public void FindAllTriplets_MatchingPairs_ReturnsAllPairs(int[] nums, int target, int expectedCount) {
        List<(int, int)> result = PairSum.FindAllPairs(nums, target);

        Assert.NotEmpty(result);
        Assert.Equal(expectedCount, result.Count);
        Assert.All(result, (x) => target.Equals(x.Item1 + x.Item2));
    }
}
