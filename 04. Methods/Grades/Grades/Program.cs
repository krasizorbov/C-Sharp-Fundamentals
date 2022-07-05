using System;

public class Program
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        Grades(a);
    }
    public static void Grades(double grade)
    {
        if (grade >= 2 && grade < 3)
        {
            Console.WriteLine("Fail");
        }
        else if (grade >= 3 && grade < 3.5)
        {
            Console.WriteLine("Poor");
        }
        else if (grade >= 3.5 && grade < 4.5)
        {
            Console.WriteLine("Good");
        }
        else if (grade >= 4.5 && grade < 5.5)
        {
            Console.WriteLine("Very good");
        }
        else if (grade >= 5.5 && grade <= 6.0)
        {
            Console.WriteLine("Excellent");
        }
    }
}