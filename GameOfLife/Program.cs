using Ipme.StarLightUnicorn.GameOfLife.Manager;
using Ipme.StarLightUnicorn.GameOfLife.Models;

var board = new Board(20, 150);

var maxRuns = 100;

var consoleManager = new ConsoleManager();
var boardManager = new BoardManager();

boardManager.InitBoard(board);

int currentRun = 0;

while (currentRun < maxRuns)
{
    Console.Clear();
    
    consoleManager.PrintBoard(board, currentRun);
    
    boardManager.Grow(board);
    
    boardManager.RemoveDeletedCell(board);
    
    boardManager.BornCell(board);
    
    Thread.Sleep(500);
    
    currentRun++;
}