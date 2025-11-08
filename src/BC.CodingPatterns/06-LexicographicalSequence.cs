namespace BC.CodingPatterns;

public class LexicographicalSequence {
    /*
    Given a string of lowercase English letters, rearrange the characters to form a new string representing the next immediate sequence in lexicographical (alphabetical) order. If the given string is already last in lexicographical order among all possible arrangements, return the arrangement that's first in lexicographical order.

    Logic:
      1. Locate the pivot
        - Pivot is the first character that breaks the incrceasing sequence from right of the string
        - If no pivot is found, the string is already at its last lexicographical sequence, and the result is just the reverse of the string
      2. Find the rightmost successor (character larger than the pivot)
      3. Swap the rightmost successor with the pivot to increase the lexicographical order of the suffix
      4. Reverse the suffix after the pivot to minimize its permutation
    */
    public static string NextSequence(string input) {
        var pivot = input.Length - 2;

        while ((pivot >= 0) && input[pivot] >= input[pivot + 1]) {
            pivot -= 1;
        }

        if (pivot < 0) {
            return string.Join("", input.Reverse());
        }

        var rightmost_successor = letters.Length - 1;
        while (letters[rightmost_successor] <= letters[pivot]) {
            rightmost_successor -= 1;
        }

        (letters[pivot], letters[rightmost_successor]) = (letters[rightmost_successor], letters[pivot]);

        var temp = pivot + 1;
        letters.AsSpan(temp).Reverse();

        return string.Join("", letters);
    }
}
