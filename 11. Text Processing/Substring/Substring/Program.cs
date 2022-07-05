using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string bigword = Console.ReadLine();

            while (bigword.Contains(word))
            {
                int index = bigword.IndexOf(word);
                bigword = bigword.Remove(index, word.Length);
            }

            Console.WriteLine(bigword);
        }
    }
}
