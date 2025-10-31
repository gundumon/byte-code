namespace BC.CodingPatterns.Tests;

public class PalindromeTests {
    [Fact]
    public void IsValid_EmptyString_ReturnsTrue() {
        string input = string.Empty;

        var isPalindrome = Palindrome.IsValid(input);

        Assert.True(isPalindrome);
    }

    [Theory]
    public void IsValid_ValidString_ReturnsTrue() {

    }
}
