using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MathUtilsTests
{
    [TestMethod]
    public void TestFactorial1()
    {
        Assert.AreEqual(1, MathUtils.Factorial(0));
    }
}