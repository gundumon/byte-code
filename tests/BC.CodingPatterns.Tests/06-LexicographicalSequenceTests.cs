namespace BC.CodingPatterns.Tests;

public class LexicographicalSequenceTests {
    [Theory]
    [InlineData(["", ""])]
    public void NextSequence_InvalidInput_ReturnsInput(string input, string expected) {
        var result = LexicographicalSequence.NextSequence(input);

        Assert.Equal(expected, result);
    }
}
