using System;

public class Program
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        double startingValueOfN = n;
        int pokes = 0;
        while (n >= m)
        {
            n -= m;
            pokes++;
            if (startingValueOfN / 2 == n)
            {
                if (y != 0)
                {
                    n = n / y;
                }
            }
        }
        Console.WriteLine(n);
        Console.WriteLine(pokes);
    }
}
