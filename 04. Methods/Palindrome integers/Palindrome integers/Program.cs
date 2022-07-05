using System;

namespace Palindrome_integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (isPalindrome((int.Parse(input))))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
            
        }

        static bool isPalindrome(int num)
        {
            int sum = 0;
            int r;
            int t;
            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
