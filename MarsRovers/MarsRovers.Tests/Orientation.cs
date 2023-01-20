namespace MarsRovers.Tests;

public abstract class Orientation
{
    protected char _key;

    public static Orientation NOrientation = new NOrientation();
    public static Orientation EOrientation = new EOrientation();
    public static Orientation SOrientation = new SOrientation();
    public static Orientation WOrientation = new WOrientation();
    public static Orientation FromChar(char orientation)
    {
        switch (orientation)
        {
            case 'N':
                return NOrientation;
            case 'E':
                return EOrientation;
            case 'S':
                return SOrientation;
            case 'W':
                return WOrientation;
            default:
                throw new ArgumentException(nameof(orientation));
        }
    }
    public abstract Orientation Previous();
    public abstract Orientation Next();
    public override string ToString()
    {
        return _key.ToString(); 
    }
}



public class NOrientation : Orientation
{
    public NOrientation()
    {
        this._key = 'N';
    }

    public override Orientation Previous()
    {
        return WOrientation;
    }

    public override Orientation Next()
    {
        return EOrientation;
    }
}
public class EOrientation : Orientation
{
    public EOrientation()
    {
        this._key = 'E';
    }

    public override Orientation Previous()
    {
        return NOrientation;
    }

    public override Orientation Next()
    {
        return SOrientation;
    }
}
public class SOrientation : Orientation
{
    public SOrientation()
    {
        this._key = 'S';
    }

    public override Orientation Previous()
    {
        return EOrientation;
    }

    public override Orientation Next()
    {
        return WOrientation;
    }
}
public class WOrientation : Orientation
{
    public WOrientation()
    {
        this._key = 'W';
    }

    public override Orientation Previous()
    {
        return SOrientation;
    }

    public override Orientation Next()
    {
        return NOrientation;
    }
}