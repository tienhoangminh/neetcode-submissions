public class Solution {
    //No duplicate in Row
    //No duplicate in Col
    //No duplicate in 3x3 box
    public bool IsValidSudoku(char[][] board) {
        int n = 9;
        HashSet<char>[] rows = new HashSet<char>[n];
        HashSet<char>[] cols = new HashSet<char>[n];
        HashSet<char>[] boxes = new HashSet<char>[n];
        
        for(int i = 0; i < n; i++)
        {
            rows[i] = new();
            cols[i] = new();
            boxes[i] = new();
        }

        for(int row = 0; row < n; row++)
        {
            for(int col = 0; col < n; col++)
            {
                char value = board[row][col];
                if(value == '.'){
                    continue;
                }

                int box = (row / 3) * 3 + (col / 3);
                if(!rows[row].Add(value) || !cols[col].Add(value) || !boxes[box].Add(value))
                {
                    return false;
                }
            }
        }

        return  true;
        
    }
}
