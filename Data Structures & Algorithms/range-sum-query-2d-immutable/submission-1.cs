public class NumMatrix {
    // To keep SumRegion's complexity is O(1) 
    // then we need to calculate almost everything in the ctor
    // to avoid loop in the SumRegion method
    // A rectangle can be viewed as the sum of all rows inside it.
    // row/col's value = total value of each cell its has (in this case cell = column/row)
    // Then let calculate value of each row first, 
    // the principle is: 
    // (1) Build horizontal prefix sums.
    // Each cell stores the sum from the leftmost column
    // to the current column in the same row.
    // (2) Build vertical prefix sums on top of the horizontal prefix.
    // Each cell now stores the sum of the rectangle
    // from (0,0) to the current position.
    private readonly int[][] prefix;
    public NumMatrix(int[][] matrix) {
        int rLength = matrix.Length;//row => yAxes
        int cLength = matrix[0].Length;//col = > xAxes
        prefix = matrix;
        
        //Calculate each column in one row then move to next row
        int row = 0;
        while(row < rLength){
            int col = 1;
            while(col < cLength){
                prefix[row][col] += prefix[row][col - 1];
                col++;
            }

            row++;
        }

        //Calculate each row in one col then move to next col
        int col2 = 0;
        while(col2 < cLength){
            int row2 = 1;
            while(row2 < rLength){
                prefix[row2][col2] += prefix[row2 - 1][col2];
                row2++;
            }

            col2++;
        }
    }

    // result = total - left + top + overide
    // total = prefix[row2][col2]
    // top = prefix[row1 - 1][col2]
    // left = prefix[row2][col1 - 1]
    // overlap = prefix[row1 - 1][col1 - 1]
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int total = prefix[row2][col2];
        int top = row1 == 0 ? 0 : prefix[row1 - 1][col2];
        int left = col1 == 0 ? 0 : prefix[row2][col1 - 1];
        int overlap = col1 == 0 || row1 == 0 ? 0 : prefix[row1 - 1][col1 - 1];

        return total - left - top + overlap;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */