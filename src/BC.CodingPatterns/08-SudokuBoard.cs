namespace BC.CodingPatterns;

/*
Given a partially completed 9×9 Sudoku board, determine if the current state of the board adheres to the rules of the game:
    - Each row and column must contain unique numbers between 1 and 9, or be empty (represented as 0)
    - Each of the nine 3×3 subgrids that compose the grid must contain unique numbers between 1 and 9, or be empty

Constraings:
    - Assume each integer on the board falls in the range of [0, 9]
*/
public class SudokuBoard {
    public static bool Verify(List<List<int>> board) {
        List<HashSet<int>> rows = [];
        List<HashSet<int>> column_sets = [];
        HashSet<int>[,] subgrid_sets = new HashSet<int>[3, 3];


        for (int i = 0; i < 9; i++) {
            rows.Add([]);
            column_sets.Add([]);
        }

        for (int r = 0; r < 3; r++) {
            for (int c = 0; c < 3; c++) {
                subgrid_sets[r, c] = [];
            }
        }

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                var num = board[r][c];
                if (num == 0) {
                    continue;
                }

                if (rows[r].Contains(num)) {
                    return false;
                }

                if (column_sets[c].Contains(num)) {
                    return false;
                }

                if (subgrid_sets[r / 3, c / 3].Contains(num)) {
                    return false;
                }

                rows[r].Add(num);
                column_sets[c].Add(num);
                subgrid_sets[r / 3, c / 3].Add(num);
            }
        }

        return true;
    }
}
