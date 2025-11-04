namespace BC.CodingPatterns.Tests;

public class ShiftZeroTests {
    [Fact]
    public void ShiftToEnd_EmptyInput_ReturnsEmpty() {
        int[] nums = [];

        var result = ShiftZero.ShiftToEnd(nums);

        Assert.Empty(result);
    }

    [Theory]
    public void ShiftToEnd_ValidInput_ShiftsZerosToEnd() {

    }
}
