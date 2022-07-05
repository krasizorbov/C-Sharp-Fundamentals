using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scanner chetec = new Scanner(System.in);

            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isEqual = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isEqual = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isEqual.ToString().ToLower());
            }
        }
    }
}
