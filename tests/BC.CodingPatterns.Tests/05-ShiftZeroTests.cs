namespace BC.CodingPatterns.Tests;

public class ShiftZeroTests {
    [Fact]
    public void ShiftToEnd_EmptyInput_ReturnsEmpty() {
        int[] nums = [];

        var result = ShiftZero.ShiftToEnd(nums);

        Assert.Empty(result);
    }

    [Theory]
    [InlineData([new int[] {0}, new int[] {0}])]
    public void ShiftToEnd_ValidInput_ShiftsZerosToEnd(int[] nums, int[] expectedResult) {
        var result = ShiftZero.ShiftToEnd(nums);

        Assert.True(Enumerable.SequenceEqual(expectedResult, result));
    }
}
