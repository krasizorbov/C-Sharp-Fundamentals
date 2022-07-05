using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arraySequence = Console.ReadLine().Split('|').Reverse().ToList();
           
            List<int> numbers = new List<int>();

            foreach (var str in arraySequence)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            
            Console.Write(string.Join(" ",numbers));
        }
    }
}
