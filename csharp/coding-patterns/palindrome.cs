bool IsPalindrome(string input) {   
    var left = 0;
    var right = input.Length - 1;

    while (left < right) {
        // skip non-alphanumeric characters from the left
        while ((left < right) && !char.IsLetterOrDigit(input[left])) {
            left += 1;
        }

        // skip non-alphanumeric characters from the right
        while ((left < right) && !char.IsLetterOrDigit(input[right])) {
            right -= 1;
        }

        // if the characters at the left and right pointers do not match, the string is not a palindrome
        if (input[left] != input[right])
            return false;

        left += 1;
        right -= 1;
    }

    return true;
}

var input = args.Length > 0 ? args[0] ?? string.Empty : string.Empty;
var result = IsPalindrome(input);

if (result) {
    Console.WriteLine($"{input} is a palindrome.");
}
else {
    Console.WriteLine($"{input} is not a palindrome.");
}
