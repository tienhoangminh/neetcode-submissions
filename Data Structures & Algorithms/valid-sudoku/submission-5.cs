public class Solution {
    //No duplicate in Row
    //No duplicate in Col
    //No duplicate in 3x3 box
    //We can find the index of each square by the equation (row / 3) * 3 + (col / 3)
    public bool IsValidSudoku(char[][] board) {
        
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i = 0; i < board.Length; i++){
            rows[i] = new();
            columns[i] = new();
            boxes[i] = new();
        }

        for(int row = 0; row < board.Length; row++){
            for(int col = 0; col < board[0].Length; col++){
                char value = board[row][col];
                if(value == '.'){
                    continue;
                }

                var index = (row/3) * 3 + (col/3);
                if(!rows[row].Add(value) || !columns[col].Add(value) || !boxes[index].Add(value)){
                    return false;
                }
            }
        }

        return true;
    }
}
