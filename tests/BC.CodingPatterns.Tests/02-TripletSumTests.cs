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
    [InlineData(new int[] { 1, 0, 1 })]
    public void FindAllTriplets_NoTriplets_ReturnsSuccess(int[] nums) {
        var triplets = TripletSum.FindAllTriplets(nums);

        Assert.True(triplets.IsSuccess);
        Assert.NotNull(triplets.Value);
        Assert.Empty(triplets.Value);
    }

    [Theory]
    [InlineData([new int[] { 0, 0, 0 }])]
    [InlineData([new int[] { 0, -1, 2, -3, 1 }])]
    [InlineData([new int[] { 0, 0, 1, -1, -1 }])]
    public void FindAllTriplets_TripletsExists_ReturnsAllTripletsThatSumToZero(int[] nums) {
        var triplets = TripletSum.FindAllTriplets(nums);

        Assert.True(triplets.IsSuccess);
        Assert.NotNull(triplets.Value);
        Assert.All(triplets.Value, t => 0.Equals(t.X + t.Y + t.Z));
    }
}
