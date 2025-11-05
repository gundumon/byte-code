namespace BC.CodingPatterns;

public class LexicographicalSequence {
    /*
    Given a string of lowercase English letters, rearrange the characters to form a new string representing the next immediate sequence in lexicographical (alphabetical) order. If the given string is already last in lexicographical order among all possible arrangements, return the arrangement that's first in lexicographical order.
    */
    public static string NextSequence(string input) {
        var letters = input.ToArray();
        var pivot = letters.Length - 2;

        // locate the first character from the right that breaks non-increasing order
        while ((pivot >= 0) && letters[pivot] >= letters[pivot + 1]) {
            pivot -= 1;
        }

        // if pivot is not found, the string is already in its largest permutation
        // reverse the string to obtain the smallest permutation
        if (pivot == -1) {
            Array.Reverse(letters);
            return string.Join("", letters);
        }

        // find the rightmost successor to the pivot
        var rightmost_successor = letters.Length - 1;
        while (letters[rightmost_successor] <= letters[pivot]) {
            rightmost_successor -= 1;
        }

        // swap the rightmost successor with the pivot to increase the lexicographical order of the suffix
        (letters[pivot], letters[rightmost_successor]) = (letters[rightmost_successor], letters[pivot]);

        // rever the suffix after the pivot to minimize its permutation
        var temp = pivot + 1;
        letters.AsSpan(temp).Reverse();

        return string.Join("", letters);
    }
}
