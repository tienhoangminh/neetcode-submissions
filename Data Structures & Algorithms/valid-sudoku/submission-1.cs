public class Solution {
    //No duplicate in Row
    //No duplicate in Col
    //No duplicate in 3x3 box
    public bool IsValidSudoku(char[][] board) {
        int n = 9;
        var set = new HashSet<char>();

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(board[i][j] == '.'){
                    continue;
                }

                if(!set.Add(board[i][j])){
                    return false;
                }
            }

            set.Clear();
        }

        set.Clear();
        for(int j = 0; j < n; j++){
            for(int i = 0; i < n; i++){
                if(board[i][j] == '.'){
                    continue;
                }

                if(!set.Add(board[i][j])){
                    return false;
                }
            }

            set.Clear();
        }

        for(int startRow = 0; startRow < 9; startRow += 3)
        {
            for(int startCol = 0; startCol < 9; startCol += 3)
            {
                set.Clear();

                for(int row = startRow; row < startRow + 3; row++)
                {
                    for(int col = startCol; col < startCol + 3; col++)
                    {
                        if(board[row][col] == '.'){
                            continue;
                        }

                        if(!set.Add(board[row][col])){
                            return false;
                        }
                    }
                }
            }
        }

        return  true;
        
    }
}
