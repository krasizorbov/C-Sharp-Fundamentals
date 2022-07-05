using System;

namespace Lower_or_upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symb = char.Parse(Console.ReadLine());
            if (Char.IsUpper(symb))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
