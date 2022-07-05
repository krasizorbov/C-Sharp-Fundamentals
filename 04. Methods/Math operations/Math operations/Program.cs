using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            double result = Calculate(num1, operatorr, num2);
            Console.WriteLine($"{result}");
        }

        static double Calculate(int num1, string operatorr, int num2)
        {
            double result = 0;
            switch (operatorr)
            {
                case "+":
                    result = (double)num1 + (double)num2;
                    break;
                case "-":
                    result = (double)num1 - (double)num2;
                    break;
                case "*":
                    result = (double)num1 * (double)num2;
                    break;
                case "/":
                    result = (double)num1 / (double)num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
