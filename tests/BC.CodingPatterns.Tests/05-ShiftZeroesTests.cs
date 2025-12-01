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
        int[] nums = [0];

        var result = ShiftZeroes.ShiftToEnd(nums);

        Assert.True(Enumerable.SequenceEqual(nums, result));
    }

    [Theory]
    [InlineData([new int[] { 0, 1, 0, 3, 2 }, new int[] { 1, 3, 2, 0, 0 }])]
    [InlineData([new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }])]
    [InlineData([new int[] { 1, 3, 2 }, new int[] { 1, 3, 2 }])]
    [InlineData([new int[] { 1, 1, 1, 0, 0 }, new int[] { 1, 1, 1, 0, 0 }])]
    [InlineData([new int[] { 0, 0, 1, 1, 1 }, new int[] { 1, 1, 1, 0, 0 }])]
    [InlineData([new int[] { 0, 1, 0, 2, 0, 3 }, new int[] { 1, 2, 3, 0, 0, 0 }])]
    public void ShiftToEnd_ValidInput_ReturnsInputWithZeroesAtEnd(int[] nums, int[] expected) {
        var result = ShiftZeroes.ShiftToEnd(nums);

        Assert.True(Enumerable.SequenceEqual(expected, result));
    }
}
