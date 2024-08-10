namespace DotNetConsoleSampleTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        var expected = "The Thing";
        var doStuff = new DoStuff();

        // Act
        var actual = doStuff.GetTheThing();

        Assert.AreEqual(expected, actual);
    }
}