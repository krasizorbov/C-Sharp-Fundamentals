using System;

namespace Sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char m = char.Parse(Console.ReadLine());
                sum += (int)m;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
