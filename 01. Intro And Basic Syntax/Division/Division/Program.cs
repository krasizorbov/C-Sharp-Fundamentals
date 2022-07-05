using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int devider = 0;
        if (number % 2 == 0)
        {
            devider = 2;
        }
        if (number % 3 == 0)
        {
            devider = 3;
        }
        if (number % 6 == 0)
        {
            devider = 6;
        }
        if (number % 7 == 0)
        {
            devider = 7;
        }
        if (number % 10 == 0)
        {
            devider = 10;
        }
        // final check
        if (devider == 0)
        {
            Console.WriteLine("Not divisible");
        }
        else
        {
            Console.WriteLine($"The number is divisible by {devider}");
        }
    }
}