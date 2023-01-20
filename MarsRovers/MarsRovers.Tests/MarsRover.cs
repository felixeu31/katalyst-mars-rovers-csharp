namespace MarsRovers.Tests;
using System.Linq;

public class MarsRover
{
    private Orientation orientation;
    private int yPosition;
    private int xPosition;

    private MarsRover() { }

    public static MarsRover Init()
    {
        return new MarsRover
        {
            orientation = Orientation.FromChar('N'),
            yPosition = 0,
            xPosition = 0
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
                yPosition++;
                break;
            case EOrientation:
                xPosition++;
                break;
            case SOrientation:
                yPosition--;
                break;
            case WOrientation:
                xPosition--;
                break;
        }
    }

    public override string ToString()
    {
        return $"{xPosition}:{yPosition}:{orientation}";
    }

}