using System;

namespace Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var number = Console.ReadLine();
            if (word == "int")
            {
                int result = Multiply(int.Parse(number));
                Console.WriteLine(result);
            }
            else if (word == "real")
            {
                double result = Multiply(double.Parse(number));
                Console.WriteLine($"{result:F2}");
            }
            else if (word == "string")
            {
                string result = Multiply(number);
                Console.WriteLine("$" + result + "$");
            }
        }

        static int Multiply(int num)
        {
            return num * 2;  
        }
        static double Multiply(double num)
        {
            return num * 1.5;
        }
        static string Multiply(string num)
        {
            return num;
        }
    }
}
