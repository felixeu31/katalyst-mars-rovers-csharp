namespace MarsRovers.Tests;
using System.Linq;

public class MarsRover
{
    private char orientation;
    private int yPosition;
    private int xPosition;

    private MarsRover() { }

    public static MarsRover Init()
    {
        return new MarsRover
        {
            orientation = 'N',
            yPosition = 0,
            xPosition = 0
        };
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            if (command.Equals('M'))
            {
                Move();
            }
            else
            {
                Rotate(command);
            }
        }

        return this.ToString();
    }

    private void Move()
    {
        switch (orientation)
        {
            case 'N':
                yPosition++;
                break;
            case 'E':
                xPosition++;
                break;
            case 'S':
                yPosition--;
                break;
            case 'W':
                xPosition--;
                break;
        }
    }

    public void Rotate(char direction)
    {
        switch (orientation)
        {
            case 'N':
                orientation = direction == 'R' ? 'E' : 'W';
                break;
            case 'E':
                orientation = direction == 'R' ? 'S' : 'N';
                break;
            case 'S':
                orientation = direction == 'R' ? 'W' : 'E';
                break;
            case 'W':
                orientation = direction == 'R' ? 'N' : 'S';
                break;
        }
    }

    public override string ToString()
    {
        return $"{xPosition}:{yPosition}:{orientation}";
    }

}