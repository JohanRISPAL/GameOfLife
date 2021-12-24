using Ipme.StarLightUnicorn.GameOfLife.Models;

namespace Ipme.StarLightUnicorn.GameOfLife.Manager;

public class ConsoleManager
{
    public ConsoleManager()
    {
        
    }

    public void PrintBoard(Board board, int currentGeneration)
    {
        Console.WriteLine($"Génération : {currentGeneration}");
        Console.WriteLine("==================");
        for(int i = 0; i < board.Cells.GetLength(0); i++){
            for (int j = 0; j < board.Cells.GetLength(1); j++)
            {
                Console.Write(board.Cells[i, j].Mark);
            }
            Console.WriteLine();
        }
        Console.SetCursorPosition(0, Console.WindowTop);
    }
}