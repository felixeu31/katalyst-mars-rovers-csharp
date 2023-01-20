namespace MarsRovers.Tests;
using System.Linq;

public class MarsRovers
{

    public string Execute(string command)
    {
        var orientation = "N";
        var yPosition = 0;
        var xPosition = 0;
        

        foreach (var singleCommand in command)
        {
            if (singleCommand.ToString().Equals("M"))
            {

                switch (orientation)
                {

                    case "N":
                        yPosition++;
                        break;
                    case "E":
                        xPosition++;
                        break;
                    case "S":
                        yPosition--;
                        break;
                    case "W":
                        xPosition--;
                        break;
                }
            }
            else
            {
                orientation = rotate(orientation, singleCommand.ToString());
            }
        }

        return $"{xPosition}:{yPosition}:{orientation}";
    }

    private string rotate(string currentOrientation, string direction)
    {
        switch (currentOrientation)
        {
            case "N":
                return direction == "R" ? "E" : "W";
            case "E":
                return direction == "R" ? "S" : "N";    
            case "S":
                return direction == "R" ? "W" : "E";
            case "W":
                return direction == "R" ? "N" : "S";
            default:
                return currentOrientation;
        }
    }
    
}