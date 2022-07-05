using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            ;
            foreach (var item in input)
            {
                Match match = Regex.Match(item, pattern);
                if (match.Success)
                {
                    Console.Write(match.Value + " ");
                }
            }
        }
    }
}
