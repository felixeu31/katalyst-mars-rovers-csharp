namespace MarsRovers.Tests;

public class Position
{
    private int _position;

    private Position() { }

    public static Position FromInteger(int position)
    {
        return new Position
        {
            _position = position
        };
    }

    public void Increment()
    {
        _position++;
    }

    public void Decrement()
    {
        _position--;
    }
    public override string ToString()
    {
        return _position.ToString();
    }

}