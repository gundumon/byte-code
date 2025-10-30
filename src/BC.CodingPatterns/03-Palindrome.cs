namespace BC.CodingPatterns;

/*
Given a string, determine if it's a palindrome after removing all non-alphanumeric characters. A character is alphanumeric if it's either a letter or a number.
*/
public class Palindrome {
    public static bool IsValid(string input) {
        if (string.IsNullOrEmpty(input)) {
            return true;
        }

        var left = 0;
        var right = input.Length - 1;

        while (left < right) {
            while ((left < right) && !char.IsLetterOrDigit(input[left])) {
                left += 1;
            }

            while ((left < right) && !char.IsLetterOrDigit(input[right])) {
                right -= 1;
            }

            if (input[left] != input[right])
                return false;

            left += 1;
            right -= 1;
        }

        return true;
    }
}