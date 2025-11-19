namespace BC.CodingPatterns.Tests;

public class PairSumSortedTests {
    [Fact]
    public void FindIndex_EmptyInput_ReturnFailure() {
        int[] nums = [];
        int target = 5;

        var result = PairSumSorted.FindIndex(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Fact]
    public void FindIndex_InputLengthLessThatTwo_ReturnsFailure() {
        int[] nums = [1];
        int target = 5;

        var result = PairSumSorted.FindIndex(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { -3, -2, -1 }, 5])]
    [InlineData([new int[] { 0, 2, 4 }, 5])]
    public void FindIndex_NoPairs_ReturnsFailure(int[] nums, int target) {
        var result = PairSumSorted.FindIndex(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { -5, -2, 3, 4, 6 }, 7])]
    [InlineData([new int[] { -3, -2, -1 }, -3])]
    public void FindIndex_PairExists_ReturnsPairThatSumsToTarget(int[] nums, int target) {
        var result = PairSumSorted.FindIndex(nums, target);

        Assert.True(result.IsSuccess);
        Assert.Equal(target, nums[result.Value.X] + nums[result.Value.Y]);
    }

    [Fact]
    public void FindPair_EmptyInput_ReturnFailure() {
        int[] nums = [];
        int target = 5;

        var result = PairSumSorted.FindPair(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Fact]
    public void FindPair_InputLengthLessThatTwo_ReturnsFailure() {
        int[] nums = [1];
        int target = 5;

        var result = PairSumSorted.FindPair(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { -3, -2, -1 }, 5])]
    [InlineData([new int[] { 0, 2, 4 }, 5])]
    public void FindPair_NoPairs_ReturnsFailure(int[] nums, int target) {
        var result = PairSumSorted.FindPair(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { -5, -2, 3, 4, 6 }, 7])]
    [InlineData([new int[] { -3, -2, -1 }, -3])]
    public void FindPair_PairExists_ReturnsPairThatSumsToTarget(int[] nums, int target) {
        var result = PairSumSorted.FindPair(nums, target);

        Assert.True(result.IsSuccess);
        Assert.Equal(target, nums[result.Value.X] + nums[result.Value.Y]);
    }

    [Fact]
    public void FindIndexes_EmptyInput_ReturnFailure() {
        int[] nums = [];
        int target = 5;

        var result = PairSumSorted.FindIndexes(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Fact]
    public void FindIndexes_InputLengthLessThatTwo_ReturnsFailure() {
        int[] nums = [3];
        int target = 3;

        var result = PairSumSorted.FindIndexes(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { -3, -2, -1 }, 5])]
    [InlineData([new int[] { 0, 2, 4 }, 5])]
    public void FindIndexes_NoPairs_ReturnsFailure(int[] nums, int target) {
        var result = PairSumSorted.FindIndexes(nums, target);

        Assert.True(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { 1, 1, 1 }, 2])]
    [InlineData([new int[] { 0, 1, 1, 1, 3 }, 2])]
    [InlineData([new int[] { 0, 1, 1, 2, 3 }, 3])]
    [InlineData([new int[] { 0, 1, 1, 2, 2, 3 }, 3])]
    public void FindIndexes_PairExists_ReturnsPairsThatSumsToTarget(int[] nums, int target) {
        var result = PairSumSorted.FindIndexes(nums, target);

        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Value);
        Assert.All(result.Value, p => target.Equals(nums[p.X] + nums[p.Y]));
    }

    [Fact]
    public void FindPairs_EmptyInput_ReturnFailure() {
        int[] nums = [];
        int target = 5;

        var result = PairSumSorted.FindPairs(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Fact]
    public void FindPairs_InputLengthLessThatTwo_ReturnsFailure() {
        int[] nums = [3];
        int target = 3;

        var result = PairSumSorted.FindPairs(nums, target);

        Assert.False(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { -3, -2, -1 }, 5])]
    [InlineData([new int[] { 0, 2, 4 }, 5])]
    public void FindPairs_NoPairs_ReturnsFailure(int[] nums, int target) {
        var result = PairSumSorted.FindPairs(nums, target);

        Assert.True(result.IsSuccess);
    }

    [Theory]
    [InlineData([new int[] { 1, 1, 1 }, 2])]
    [InlineData([new int[] { 0, 1, 1, 1, 3 }, 2])]
    [InlineData([new int[] { 0, 1, 1, 2, 3 }, 3])]
    [InlineData([new int[] { 0, 1, 1, 2, 2, 3 }, 3])]
    public void FindPairs_PairExists_ReturnsPairsThatSumsToTarget(int[] nums, int target) {
        var result = PairSumSorted.FindPairs(nums, target);

        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Value);
        Assert.All(result.Value, p => target.Equals(nums[p.X] + nums[p.Y]));
    }
}
