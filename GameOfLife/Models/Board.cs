namespace Ipme.StarLightUnicorn.GameOfLife.Models;

public class Board
{
    private int _heigth;
    private int _width;
    private Cell[,] _cells;

    public Board(int heigth, int width)
    {
        _heigth = heigth;
        _width = width;
        _cells = new Cell[heigth, width];
    }

    public int Heigth
    {
        get => _heigth;
    }

    public int Width
    {
        get => _width;
    }
    
    public Cell[,] Cells
    {
        get => _cells;
    }
}