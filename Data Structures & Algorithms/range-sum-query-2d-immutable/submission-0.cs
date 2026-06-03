public class NumMatrix {
    private int[][] prefix;

    // Pre-calculate from 0,0 to m,n first
    public NumMatrix(int[][] matrix) {
        int r = 0;
        while(r < matrix.Length){
            int c = 1;
            while(c < matrix[0].Length){
                matrix[r][c] += matrix[r][c - 1];
                c++;
            }
            r++;
        }

        int c2 = 0;
        while(c2 < matrix[0].Length){
            int r2 = 1;
            while(r2 < matrix.Length){
                matrix[r2][c2] += matrix[r2 - 1][c2];
                r2++;
            }
            c2++;
        }

        prefix = matrix;
    }
    
    // SumgRegion = Total - Top - Left + Overlapp (if have)
    // Total = matrix[m][n], Top = matrix[row1 - 1][col2], Left = matrix[row2][col1 - 1]
    // Overlap = matrix[row1 - 1][col1 - 1]
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int total = prefix[row2][col2];
        int top = row1 == 0 ? 0 : prefix[row1 - 1][col2];
        int left = col1 == 0 ? 0 :prefix[row2][col1 - 1];
        int overlap = row1 == 0 || col1 == 0 ? 0 : prefix[row1 - 1][col1 - 1];
        return total - top - left + overlap;
    }
}


/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */