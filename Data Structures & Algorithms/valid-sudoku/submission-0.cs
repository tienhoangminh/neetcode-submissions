public class Solution {
    //No duplicate in Row
    //No duplicate in Col
    //No duplicate in 3x3 box
    public bool IsValidSudoku(char[][] board) {
        int n = 9;
        var set = new HashSet<int>();

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(board[i][j] == '.'){
                    continue;
                }

                int value = int.Parse(board[i][j].ToString());
                if(!set.Add(value)){
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

                int value = int.Parse(board[i][j].ToString());
                if(!set.Add(value)){
                    return false;
                }
            }

            set.Clear();
        }
        
        for(int k = 0; k < n; k = k + 3){
            for(int j = 0; j < n; j++){
                for(int i = k; i < k+3; i++){
                    if(board[i][j] == '.'){
                        continue;
                    }

                    int value = int.Parse(board[i][j].ToString());
                    if(!set.Add(value)){
                        return false;
                    }
                }
                
                if(j == 2 || j == 5 || j == 8){
                    set.Clear();
                }
            }
        }

        return  true;
        
    }
}
