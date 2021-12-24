using Ipme.StarLightUnicorn.GameOfLife.Models;

namespace Ipme.StarLightUnicorn.GameOfLife.Manager;

public class BoardManager
{
    public BoardManager()
    {
        
    }

    public void InitBoard(Board board)
    {
        Random random = new Random();

        for(int i = 0; i < board.Cells.GetLength(0); i++){
            for (int j = 0; j < board.Cells.GetLength(1); j++)
            {
                board.Cells[i, j] = new Cell(" ", false, false, false);
                int isAlive = random.Next(4);

                if (isAlive == 1)
                {
                    board.Cells[i, j].Mark = "X";
                    board.Cells[i, j].IsAlive = true;
                }
            }
        }
        
        //Beehive
        /*board.Cells[1,2] = new Cell("X", true, false, false);
        board.Cells[1,3] = new Cell("X", true, false, false);
        board.Cells[2,1] = new Cell("X", true, false, false);
        board.Cells[2,4] = new Cell("X", true, false, false);
        board.Cells[3,2] = new Cell("X", true, false, false);
        board.Cells[3,3] = new Cell("X", true, false, false);*/
        
        //Square
        /*board.Cells[9,9] = new Cell("X", true, false, false);
        board.Cells[9,10] = new Cell("X", true, false, false);
        board.Cells[10,9] = new Cell("X", true, false, false);
        board.Cells[10,10] = new Cell("X", true, false, false);*/
        
        //Blinker
        /*board.Cells[15,15] = new Cell("X", true, false, false);
        board.Cells[15,16] = new Cell("X", true, false, false);
        board.Cells[15,17] = new Cell("X", true, false, false);*/

        //Glider
        /*board.Cells[0,1] = new Cell("X", true, false, false);
        board.Cells[1,2] = new Cell("X", true, false, false);
        board.Cells[2,0] = new Cell("X", true, false, false);
        board.Cells[2,1] = new Cell("X", true, false, false);
        board.Cells[2,2] = new Cell("X", true, false, false);*/

    }

    public int GetAliveNeighbors(Board board, int x, int y)
    {
        int numOfAliveNeighbors = 0;
        
        for (int i = x - 1; i <= x + 1; i++) {
            for (int j = y - 1; j <= y + 1; j++) {
                if (!((i < 0 || j < 0) || (i >= board.Heigth || j >= board.Width)))
                {
                    if(!((i == x) && (j == y)))
                    {
                        if (board.Cells[i, j].IsAlive == true) numOfAliveNeighbors++;
                    }                            
                }
            }
        }

        return numOfAliveNeighbors;
    }

    public void Grow(Board board)
    {
        for(int i = 0; i < board.Cells.GetLength(0); i++){
            for (int j = 0; j < board.Cells.GetLength(1); j++)
            {
                int numOfAliveNeighbors = GetAliveNeighbors(board, i, j);
                
                if (board.Cells[i, j].IsAlive)
                {
                    if (numOfAliveNeighbors is < 2 or > 3)
                    {
                        board.Cells[i, j].DeletedLastTurn = true;
                    }
                }
                else
                {
                    if (numOfAliveNeighbors == 3)
                    {
                        board.Cells[i, j].IsBorn = true;
                    }
                }
                
            }
        }
    }

    public void BornCell(Board board)
    {
        for (int i = 0; i < board.Cells.GetLength(0); i++)
        {
            for (int j = 0; j < board.Cells.GetLength(1); j++)
            {
                if(board.Cells[i, j].IsBorn)
                {
                    board.Cells[i, j].Mark = "X";
                    board.Cells[i, j].IsAlive = true;
                    board.Cells[i, j].IsBorn = false;
                }
            }
        }
    }

    public void RemoveDeletedCell(Board board)
    {
        for (int i = 0; i < board.Cells.GetLength(0); i++)
        {
            for (int j = 0; j < board.Cells.GetLength(1); j++)
            {
                if(board.Cells[i, j].DeletedLastTurn)
                {
                    board.Cells[i, j].Mark = " ";
                    board.Cells[i, j].IsAlive = false;
                    board.Cells[i, j].DeletedLastTurn = false;
                }
            }
        }
    }
}