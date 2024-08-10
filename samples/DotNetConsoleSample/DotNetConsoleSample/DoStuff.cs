namespace DotNetConsoleSample;


public class DoStuff
{
    private readonly string _theThing;

    public DoStuff()
    {
        _theThing = "The Thing";
    }

    public string GetTheThing()
    {
        return _theThing;
    }
}
