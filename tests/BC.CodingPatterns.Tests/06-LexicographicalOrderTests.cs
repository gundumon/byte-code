namespace BC.CodingPatterns.Tests;

public class LexicographicalOrderTests {
    [Fact]
    public void NextSequence_EmptyInput_ReturnsEmptyString() {
        var input = "";

        var result = LexicographicalOrder.NextSequence(input);

        Assert.True(result == string.Empty);
    }

    [Theory]
    [InlineData(["a", "a"])]
    [InlineData(["abcd", "abdc"])]
    [InlineData(["dcba", "abcd"])]
    [InlineData(["aaaa", "aaaa"])]
    [InlineData(["ynitsed", "ynsdeit"])]
    [InlineData(["abcedda", "abdacde"])]
    public void NextSequence_ValidInput_ReturnsNextLexicographicalSequence(string input, string expected) {
        var result = LexicographicalOrder.NextSequence(input);

        Assert.Equal(expected, result);
    }
}
