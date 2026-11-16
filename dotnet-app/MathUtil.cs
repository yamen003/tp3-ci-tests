using System;
public static class MathUtils
{
public static int Factorial(int n)
{
if (n < 0) throw new ArgumentException("n must be non-negative");
return n <= 1 ? 1 : n * Factorial(n - 1);
}
}
[TestMethod]
public void TestFactorial0()
{
Assert.AreEqual(0, MathUtils.Factorial(0));
}