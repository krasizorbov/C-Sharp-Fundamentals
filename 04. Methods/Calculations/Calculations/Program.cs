using System;

public class Program
{
    public static void Main()
    {
        string operation = Console.ReadLine();
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        if (operation == "add")
        {
            Add(num1, num2);
        }
        else if (operation == "subtract")
        {
            Substract(num1, num2);
        }
        else if (operation == "divide")
        {
            Devide(num1, num2);
        }
        else if (operation == "multiply")
        {
            Multiply(num1, num2);
        }

    }
    public static void Add(double x, double y)
    {
        double result = x + y;
        Console.WriteLine(result);
    }
    public static void Substract(double x, double y)
    {
        double result = x - y;
        Console.WriteLine(result);
    }
    public static void Devide(double x, double y)
    {
        {
            double result = x / y;
            Console.WriteLine(result);
        }

    }
    public static void Multiply(double x, double y)
    {
        double result = x * y;
        Console.WriteLine(result);
    }
}