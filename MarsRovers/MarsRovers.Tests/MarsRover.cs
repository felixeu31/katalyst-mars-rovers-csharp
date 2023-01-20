namespace MarsRovers.Tests;
using System.Linq;

public class MarsRover
{
    private Orientation orientation;
    private Position yPosition;
    private Position xPosition;

    private MarsRover(Orientation orientation, Position yPosition, Position xPosition)
    {
        this.orientation = orientation;
        this.yPosition = yPosition;
        this.xPosition = xPosition;
    }

    public static MarsRover Init()
    {
        return new MarsRover(
            Orientation.FromChar('N'), Position.FromInteger(0), Position.FromInteger(0));
    }

    public string ExecuteCommands(string commands)
    {
        foreach (var singleCommand in commands)
        {
            ExecuteCommand(singleCommand);
        }

        return this.ToString();
    }

    private void ExecuteCommand(char singleCommand)
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