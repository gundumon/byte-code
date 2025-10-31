namespace BC.CodingPatterns.Tests;

public class PalindromeTests {
    [Fact]
    public void IsValid_EmptyString_ReturnsTrue() {
        string input = string.Empty;

        var isPalindrome = Palindrome.IsValid(input);

        Assert.True(isPalindrome);
    }

    [Theory]
    [InlineData(["a"])]
    [InlineData(["aa"])]
    [InlineData(["!, (?)"])]
    [InlineData(["12.02.2021"])]
    public void IsValid_ValidString_ReturnsTrue(string input) {
        var isPalindrome = Palindrome.IsValid(input);

        Assert.True(isPalindrome);
    }
}
