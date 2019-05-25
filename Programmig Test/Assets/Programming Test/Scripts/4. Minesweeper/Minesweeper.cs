public class Minesweeper 
{
    public int[,] Mines(int[,] board)
    {
        int[,] mines = new int[4,4];
        int count = 0;
        
        for (int i = 0; i < board.Length - 1; i++)
        {
            for (int j = 0; j < board.Length - 1; j++)
            {
                if (board[i,j] == 1)
                {
                    mines[i, j] = -1;
                }

                if (board[i,j] == 0)
                {
                    /*if ((i+1 < board.Length || i+1 > 0) && board[i+1,j] == 1)
                    {
                        count++;
                    }

                    if ((j+1 < board.Length || j+1 > 0) && board[i,j+1] == 1)
                    {
                        count++;
                    }
                    
                    if ((i+1 < board.Length || i+1 > 0) && (j+1 < board.Length || j+1 > 0) && board[i+1,j+1] == 1)
                    {
                        count++;
                    }
                    
                    if ((i-1 <= board.Length || i-1 >= 0) && board[i-1,j] == 1)
                    {
                        count++;
                    }
                    
                    if ((i-1 < board.Length || i-1 > 0) && (j+1 < board.Length || j+1 > 0) && board[i-1,j+1] == 1)
                    {
                        count++;
                    }
                    
                    if ((j-1 < board.Length || j-1 > 0) && board[i,j-1] == 1)
                    {
                        count++;
                    }
                    
                    if ((i+1 < board.Length || i+1 > 0) && (j-1 < board.Length || j-1 > 0) && board[i+1,j-1] == 1)
                    {
                        count++;
                    }
                    
                    if ((i-1 < board.Length || i-1 > 0) && (j-1 < board.Length || j-1 > 0) && board[i-1,j-1] == 1)
                    {
                        count++;
                    }*/

                    count++;
                    
                    mines[i, j] = count;
                }
                count = 0;
            }
        }
        return mines;
    }
}
