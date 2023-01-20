namespace MarsRovers.Tests;

public class Position
{
    private int _position;

    private Position(int position)
    {
        _position = position;
    }

    public static Position FromInteger(int position)
    {
        return new Position(position);
    }

    public void Increment()
    {
        if (_position == 9)
        {
            _position = 0;
        }
        else
        {
            _position++;
        }
    }

    public void Decrement()
    {
        if (_position == 0)
        {
            _position = 9;
        }
        else
        {
            _position--;
        }
    }
    public override string ToString()
    {
        return _position.ToString();
    }

}