namespace BC.CodingPatterns;

/*
Given a string, determine if it's a palindrome after removing all non-alphanumeric characters. A character is alphanumeric if it's either a letter or a number.
*/
public class Palindrome {
    public static bool IsValid(string input) {
        if (string.IsNullOrWhiteSpace(input)) {
            return true;
        }

        int left = 0;
        int right = input.Length - 1;
    }
}