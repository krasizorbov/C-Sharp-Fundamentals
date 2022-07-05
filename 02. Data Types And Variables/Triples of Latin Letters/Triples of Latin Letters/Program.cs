using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char first = 'a';
            char second = 'b';
            char third = 'c';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        first = (char)('a' + i);
                        second = (char)('a' + j);
                        third = (char)('a' + k);
                        Console.Write(first);
                        Console.Write(second);
                        Console.Write(third);
                        Console.WriteLine();
                    }
                }
            }
            
        }
    }
}
