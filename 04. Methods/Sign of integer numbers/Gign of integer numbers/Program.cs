using System;

public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        PositiveNegative(a);
    }
    public static void PositiveNegative(int x)
    {
        if (x > 0)
        {
            Console.WriteLine("The number {0} is positive.", x);
        }
        else if (x < 0)
        {
            Console.WriteLine("The number {0} is negative.", x);
        }
        else
        {
            Console.WriteLine("The number {0} is zero.", x);
        }
    }
}