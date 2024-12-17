using NUnit.Framework;

[TestFixture]
public class FermatFactorizationTests
{
    [Test]
    public void TestFactorizationWithSmallPrimeProduct()
    {
        long numberToFactor = 5959; // 59 * 101
        var factors = FermatFactorization.FermatFactor(numberToFactor);
        Assert.AreEqual(59, factors.Item1);
        Assert.AreEqual(101, factors.Item2);
    }

    [Test]
    public void TestFactorizationWithProductOfTwoPrimes()
    {
        long numberToFactor = 221; // 13 * 17
        var factors = FermatFactorization.FermatFactor(numberToFactor);
        Assert.AreEqual(17, factors.Item1);
        Assert.AreEqual(13, factors.Item2);
    }

    [Test]
    public void TestFactorizationWithPerfectSquare()
    {
        long numberToFactor = 144; // 12 * 12
        var factors = FermatFactorization.FermatFactor(numberToFactor);
        Assert.AreEqual(12, factors.Item1);
        Assert.AreEqual(12, factors.Item2);
    }
}