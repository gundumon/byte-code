namespace BC.CodingPatterns;

public class LexicographicalSequence {
    /*
    Given a string of lowercase English letters, rearrange the characters to form a new string representing the next immediate sequence in lexicographical (alphabetical) order. If the given string is already last in lexicographical order among all possible arrangements, return the arrangement that's first in lexicographical order.

    Logic:
      1. Locate the pivot
        - Pivot is the first character from the right that breaks the increasing sequence
        - If no pivot is found, the string is already at its last lexicographical sequence, and the result is just the reverse of the string
      2. Find the rightmost successor (character larger than the pivot)
      3. Swap the rightmost successor with the pivot to increase the lexicographical order of the suffix
      4. Reverse the suffix after the pivot to minimize its permutation
    */
    public static string NextSequence(string input) {
        if (string.IsNullOrWhiteSpace(input) || input.Length < 3) {
            return input;
        }

        var letters = input.ToArray();
        var pivot = input.Length - 2;

        while ((pivot >= 0) && letters[pivot] >= letters[pivot + 1]) {
            pivot -= 1;
        }

        if (pivot < 0) {
            return string.Join("", letters.Reverse());
        }

        var successor = letters.Length - 1;
        while (letters[successor] <= letters[pivot]) {
            successor -= 1;
        }

        (letters[pivot], letters[successor]) = (letters[successor], letters[pivot]);

        var temp = pivot + 1;
        letters.AsSpan(temp).Reverse();

        return string.Join("", letters);
    }
}
