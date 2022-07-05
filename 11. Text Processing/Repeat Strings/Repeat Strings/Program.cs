using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myword = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            foreach (var word in myword)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
