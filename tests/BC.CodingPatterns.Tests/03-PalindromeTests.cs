namespace BC.CodingPatterns.Tests;

public class PalindromeTests {
    [Fact]
    public void IsValid_EmptyString_ReturnsTrue() {
        string input = "";

        var isPalindrome = Palindrome.IsValid(input);

        Assert.True(isPalindrome);
    }

    [Theory]
    [InlineData(["a dog! a panic in a pagoda."])]
    [InlineData(["racecar"])]
    [InlineData(["a"])]
    [InlineData(["aa"])]
    [InlineData(["!, (?)"])]
    [InlineData(["12.02.2021"])]
    public void IsValid_InputIsPalindrome_ReturnsTrue(string input) {
        var isPalindrome = Palindrome.IsValid(input);

        Assert.True(isPalindrome);
    }

    [Theory]
    [InlineData(["abc123"])]
    [InlineData(["ab"])]
    [InlineData(["21.02.2021"])]
    [InlineData(["hello, world!"])]
    public void IsValid_InputIsNotPalindrome_ReturnsFalse(string input) {
        var isPalindrome = Palindrome.IsValid(input);

        Assert.False(isPalindrome);
    }
}
