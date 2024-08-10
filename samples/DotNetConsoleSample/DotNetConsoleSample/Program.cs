using System.Diagnostics.CodeAnalysis;

namespace DotNetConsoleSample;

[ExcludeFromCodeCoverage]
internal static class Program
{
    static void Main(string[] args)
    {
        var doStuff = new DoStuff();
        var theThing = doStuff.GetTheThing();
        Console.WriteLine(theThing);
    }
}
