namespace CodingPatterns;

/*
For each zero in an m x n matrix, set its entire row and column to zero in place.
*/
public class ZeroStripping {
    public static void SetZeroes(List<List<int>> matrix) {
        HashSet<int> zero_rows = [];
        HashSet<int> zero_columns = [];

        for(int r = 0; r < matrix[0].Count; r++) {
            for (int c = 0; c < matrix.Count; c++) {
                if (matrix[r][c] == 0) {
                    zero_rows.Add(r);
                    zero_columns.Add(c);
                }
            }
        }

        for (int r = 0; r < matrix[0].Count; r++) {
            for (int c = 0; c < matrix.Count; c++) {
                
            }
        }
    }
}
