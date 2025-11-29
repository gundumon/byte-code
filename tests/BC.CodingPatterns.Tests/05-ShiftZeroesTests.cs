namespace BC.CodingPatterns.Tests;

public class ShiftZeroesTests {
    [Fact]
    public void ShiftToEnd_InputLengthZero_ReturnsInput() {
        int[] nums = [];

        var result = ShiftZeroes.ShiftToEnd(nums);

        Assert.True(Enumerable.SequenceEqual(nums, result));
    }

    [Fact]
    public void ShiftToEnd_InputLengthLessThanTwo_ReturnsInput() {

    }
}
