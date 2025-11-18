namespace BC.CodingPatterns;

/*
For each zero in an m x n matrix, set its entire row and column to zero in place.
*/
public class ZeroStripping {
    public static List<List<int>> SetZeroes(List<List<int>> matrix) {
        if (matrix.Count == 0)
            return [];

        HashSet<int> zero_rows = [];
        HashSet<int> zero_columns = [];

        // pass 1: traverse through the matrix to identify the rows and columns
        // containing zeros and store their indexes in the appropriate hash sets
        for (int r = 0; r < matrix.Count; r++) {
            for (int c = 0; c < matrix[0].Count; c++) {
                if (matrix[r][c] == 0) {
                    zero_rows.Add(r);
                    zero_columns.Add(c);
                }
            }
        }

        // pass 2: set any cell in the matrix to zero if its row index is in 'zero_rows' 
        // or its column index is in 'zero_columns'
        for (int r = 0; r < matrix.Count; r++) {
            for (int c = 0; c < matrix[0].Count; c++) {
                if (zero_rows.Contains(r) || zero_columns.Contains(c)) {
                    matrix[r][c] = 0;
                }
            }
        }

        return matrix;
    }
}
