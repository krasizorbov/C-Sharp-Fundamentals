using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Replace_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);

            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i] == sb[i-1])
                {
                    sb = sb.Remove(i - 1, 1);
                    i = 0;
                }
            }
            
            Console.WriteLine(sb);
        }
    }
}
