    // Runtime 238 ms
    // Memory 42.5 MB

    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int columns = board[0].Length;

        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                if(DFS(i, j, 0))
                    return true;

        return false;    
    
        bool DFS(int row, int column, int start){
            if(start == word.Length) 
                return true;

            if(row < 0 || row >= rows || column < 0 || column >= columns || board[row][column] != word[start])
                return false;

            char temp = board[row][column];
            board[row][column] = '~';

            bool result = DFS(row + 1, column, start + 1) ||
                          DFS(row - 1, column, start + 1) ||
                          DFS(row, column + 1, start + 1) ||
                          DFS(row, column - 1, start + 1);
    
            board[row][column] = temp;
    
            return result;   
        }
    }
