using System;

namespace Sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum =0;
            int digit;
            int length = n.Length;
            for (int i = 0; i < length; i++)
            {
                digit = n[i] - '0';
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
