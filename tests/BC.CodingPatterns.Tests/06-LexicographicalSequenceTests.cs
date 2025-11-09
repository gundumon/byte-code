namespace BC.CodingPatterns.Tests;

public class LexicographicalSequenceTests {
    [Theory]
    [InlineData(["", ""])]
    public void NextSequence_InvalidInput_ReturnsInput(string input, string expected) {
        var result = LexicographicalSequence.NextSequence(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(["a", "a"])]
    [InlineData(["abcd", "abdc"])]
    [InlineData(["dcba", "abcd"])]
    [InlineData(["aaaa", "aaaa"])]
    [InlineData(["ynitsed", "ynsdeit"])]
    [InlineData(["abcedda", "abdacde"])]
    public void NextSequence_ValidInput_ReturnsSequence(string input, string expected) {
        var result = LexicographicalSequence.NextSequence(input);

        Assert.Equal(expected, result);
    }
}
