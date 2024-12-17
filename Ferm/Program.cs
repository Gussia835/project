using System;

class FermatFactorization
{
    // является ли число полным квадратом
    static bool IsPerfectSquare(long number)
    {
        long sqrt = (long)Math.Sqrt(number);
        return sqrt * sqrt == number;
    }

    // Реализация метода факторизации Ферма
    static (long, long) FermatFactor(long N)
    {
        long x = (long)Math.Ceiling(Math.Sqrt(N));
        long y2;

        while (true)
        {
            y2 = x * x - N;
            if (IsPerfectSquare(y2))
            {
                long y = (long)Math.Sqrt(y2);
                return (x + y, x - y);
            }
            x++;
        }
    }

    static void Main(string[] args)
    {
        long numberToFactor = 5959;
        var factors = FermatFactor(numberToFactor);
        Console.WriteLine($"Факторы числа {numberToFactor} равны {factors.Item1} и {factors.Item2}.");
    }
}
