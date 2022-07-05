using System;

public class Program
{
    public static void Main()
    {
        string n = Console.ReadLine();
        int length = n.Length;

        int digit = n[length - 1] - '0';

        if (digit == 1)
        {
            Console.WriteLine("one");
        }
        else if (digit == 2)
        {
            Console.WriteLine("two");
        }
        else if (digit == 3)
        {
            Console.WriteLine("three");
        }
        else if (digit == 4)
        {
            Console.WriteLine("four");
        }
        else if (digit == 5)
        {
            Console.WriteLine("five");
        }
        else if (digit == 6)
        {
            Console.WriteLine("six");
        }
        else if (digit == 7)
        {
            Console.WriteLine("seven");
        }
        else if (digit == 8)
        {
            Console.WriteLine("eight");
        }
        else if (digit == 9)
        {
            Console.WriteLine("nine");
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
}