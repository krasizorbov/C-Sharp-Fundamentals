using System;

public class Program
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double esp = 0.000001;

        if (Math.Abs(a - b) < esp)
        {
            Console.WriteLine(true);
        }
        else if (Math.Abs(a - b) == esp)
        {
            Console.WriteLine(false);
        }
        else if (Math.Abs(a - b) > esp)
        {
            Console.WriteLine(false);
        }
    }
}