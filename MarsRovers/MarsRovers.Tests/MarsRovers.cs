namespace MarsRovers.Tests;
using System.Linq;

public class MarsRovers
{

    public string Execute(string command)
    {
        var orientation = "N";
        var yPosition = 0;
        

        foreach (var singleCommand in command)
        {
            if (singleCommand.ToString().Equals("M"))
            {
                yPosition++;
            }
            else
            {
                orientation = rotate(orientation, singleCommand.ToString());
            }
        }

        return $"0:{yPosition}:{orientation}";
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