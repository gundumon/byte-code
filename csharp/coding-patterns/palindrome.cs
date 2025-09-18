bool IsPalindrome(string[] args) {
    var input = args.Length > 0 ? args[0] ?? string.Empty : string.Empty;

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
}

IsPalindrome(args);
