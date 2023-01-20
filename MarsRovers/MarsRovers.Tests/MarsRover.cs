namespace MarsRovers.Tests;
using System.Linq;

public class MarsRover
{
    private Orientation orientation;
    private Position yPosition;
    private Position xPosition;

    private MarsRover() { }

    public static MarsRover Init()
    {
        return new MarsRover
        {
            orientation = Orientation.FromChar('N'),
            yPosition = Position.FromInteger(0),
            xPosition = Position.FromInteger(0)
        };
    }

    public string Execute(string commands)
    {
        foreach (var singleCommand in commands)
        {
            switch (Command.FromChar(singleCommand))
            {
                case MoveCommand:
                    Move();
                    break;
                case LeftCommand:
                    orientation = orientation.Previous();
                    break;
                case RightCommand:
                    orientation = orientation.Next();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Command));
            }
        }

        return this.ToString();
    }

    private void Move()
    {
        switch (orientation)
        {
            case NOrientation:
                yPosition.Increment();
                break;
            case EOrientation:
                xPosition.Increment();
                break;
            case SOrientation:
                yPosition.Decrement();
                break;
            case WOrientation:
                xPosition.Decrement();
                break;
        }
    }

    public override string ToString()
    {
        return $"{xPosition}:{yPosition}:{orientation}";
    }

}