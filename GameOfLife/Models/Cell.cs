namespace Ipme.StarLightUnicorn.GameOfLife.Models;

public class Cell
{
    private string _mark;
    private int _generation;
    private bool _isAlive;
    private bool _isBorn;
    private bool _deletedLastTurn;

    public Cell(string mark, bool isAlive, bool isBorn, bool deletedLastTurn)
    {
        _mark = mark;
        _generation = 0;
        _isAlive = isAlive;
        _isBorn = isBorn;
        _deletedLastTurn = deletedLastTurn;
    }

    public string Mark
    {
        get => _mark;
        set => _mark = value;
    }

    public int Generation
    {
        get => _generation;
        set => _generation = value;
    }

    public bool IsAlive
    {
        get => _isAlive;
        set => _isAlive = value;
    }

    public bool IsBorn
    {
        get => _isBorn;
        set => _isBorn = value;
    }

    public bool DeletedLastTurn
    {
        get => _deletedLastTurn;
        set => _deletedLastTurn = value;
    }
}