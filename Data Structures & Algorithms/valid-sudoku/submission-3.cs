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

        //box = (row / 3) * 3 + (col / 3)
        var boxes = new HashSet<string>();
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(board[i][j] == '.'){
                    continue;
                }

                int box = (i / 3) * 3 + (j / 3);
                if(!boxes.Add(box + "-" + board[i][j])){
                    return false;
                }
            }
        }
        

        return  true;
        
    }
}
