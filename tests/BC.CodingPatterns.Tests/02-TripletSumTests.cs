using System.Security.Cryptography;

namespace BC.CodingPatterns.Tests;

public class TripletSumTests {
    [Fact]
    public void FindAllTriplets_EmptyInput_ReturnsFailure() {
        int[] nums = [];

        var triplets = TripletSum.FindAllTriplets(nums);

        Assert.False(triplets.IsSuccess);
    }

    [Fact]
    public void FindAllTriplets_InputLengthLessThanThree_ReturnsFailure() {
        int[] nums = [1, 2];

        var triplets = TripletSum.FindAllTriplets(nums);

        Assert.False(triplets.IsSuccess);
    }

    [Theory]
    [InlineData(new int[] { -2, 0, 3 })]
    [InlineData(new int[] { -3, -2, 1, 4 })]
    public void FindAllTriplets_NoMatchingPair_ReturnsEmpty(int[] nums) {
        HashSet<(int a, int b, int c)> result = TripletSum.FindAllTriplets(nums);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Theory]
    [InlineData([new int[] { 0, 0, 0 }, 1])]
    [InlineData([new int[] { -3, -1, 0, 1, 2 }, 2])]
    [InlineData([new int[] { 0, 0, 1, -1, 1, -1 }, 1])]
    public void FindAllTriplets_MatchingPairs_ReturnsAllPairs(int[] nums, int expectedCount) {
        HashSet<(int a, int b, int c)> result = TripletSum.FindAllTriplets(nums);

        Assert.NotEmpty(result);
        Assert.Equal(expectedCount, result.Count);
        Assert.All(result, (x) => (x.a + x.b + x.c).Equals(0));
    }
}
