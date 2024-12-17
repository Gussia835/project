using NUnit.Framework;

[TestFixture]
public class FermatFactorizationTests
{

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

    [Test]
    public void TestFactorizationWithSquareOfPrime()
    {
        long numberToFactor = 49; // 7 * 7
        var factors = FermatFactorization.FermatFactor(numberToFactor);
        Assert.AreEqual(7, factors.Item1);
        Assert.AreEqual(7, factors.Item2);
    }

}