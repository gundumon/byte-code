namespace BC.CodingPatterns;

public class LexicographicalOrder {
    /*
    Given a string of lowercase English letters, rearrange the characters to form a new string representing the next immediate sequence in lexicographical (alphabetical) order. If the given string is already last in lexicographical order among all possible arrangements, return the arrangement that's first in lexicographical order.
    */
    public static string NextSequence(string input) {
        if (string.IsNullOrWhiteSpace(input)) {
            return string.Empty;
        }

        var letters = input.ToCharArray();
        var pivot = input.Length - 2;

        // find the first character from right (pivot) that breaks the increasing sequence
        while ((pivot >= 0) && letters[pivot] >= letters[pivot + 1]) {
            pivot -= 1;
        }

        // if not found, string is already in the last lexicographical sequence. so just reverse the original string and return
        if (pivot < 0) {
            return string.Join("", letters.Reverse());
        }

        // find the first character (successor) from the right which is larger than the pivot character
        var successor = letters.Length - 1;
        while (letters[successor] <= letters[pivot]) {
            successor -= 1;
        }

        // swap the characters at pivot and successor
        (letters[pivot], letters[successor]) = (letters[successor], letters[pivot]);

        // reverse the string after the pivot
        var temp = pivot + 1;
        letters.AsSpan(temp).Reverse();

        return string.Join("", letters);
    }
}
