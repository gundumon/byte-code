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
    public void FindAllTriplets_InputLengthLessThamTwo_ReturnsEmpty() {
        int[] nums = [];

        HashSet<(int a, int b, int c)> result = TripletSum.FindAllTriplets(nums);

        Assert.NotNull(result);
        Assert.Empty(result);
    }
}
