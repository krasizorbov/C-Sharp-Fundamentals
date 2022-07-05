using System;

namespace Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char m;
            for (int i = num1; i <= num2; i++)
            {
                m = (char)i;
                Console.Write(m + " ");
            }
        }
    }
}
