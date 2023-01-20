namespace MarsRovers.Tests;

public abstract class Command
{
    public static Command MoveCommand = new MoveCommand();
    public static Command RightCommand = new RightCommand();
    public static Command LeftCommand = new LeftCommand();
    public static Command FromChar(char orientation)
    {
        switch (orientation)
        {
            case 'M':
                return MoveCommand;
            case 'R':
                return RightCommand;
            case 'L':
                return LeftCommand;
            default:
                throw new ArgumentException(nameof(orientation));
        }
    }
}

public class MoveCommand : Command
{
}
public class RightCommand : Command
{
}
public class LeftCommand : Command
{
}