using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Digits_Letters_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    Console.Write(word[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    Console.Write(word[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetterOrDigit(word[i]))
                {
                    Console.Write(word[i]);
                }
            }
        }
    }
}
