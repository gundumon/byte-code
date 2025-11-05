namespace BC.CodingPatterns.Tests;

public class ShiftZeroTests {
    [Fact]
    public void ShiftToEnd_EmptyInput_ReturnsEmpty() {
        int[] nums = [];

        var result = ShiftZero.ShiftToEnd(nums);

        Assert.Empty(result);
    }

    [Theory]
    [InlineData([new int[] { 0 }, new int[] { 0 }])]
    [InlineData([new int[] { 1 }, new int[] { 1 }])]
    [InlineData([new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }])]
    [InlineData([new int[] { 1, 3, 2 }, new int[] { 1, 3, 2 }])]
    [InlineData([new int[] { 1, 1, 1, 0, 0 }, new int[] { 1, 1, 1, 0, 0 }])]
    [InlineData([new int[] { 0, 0, 1, 1, 1 }, new int[] { 1, 1, 1, 0, 0 }])]
    public void ShiftToEnd_ValidInput_ShiftsZerosToEnd(int[] nums, int[] expectedResult) {
        var result = ShiftZero.ShiftToEnd(nums);

        Assert.Equal(expectedResult, result);
    }
}
