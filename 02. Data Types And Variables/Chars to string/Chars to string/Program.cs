using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            var builder = new StringBuilder();
            int count = 0;
            foreach (var c in alpha)
            {
                builder.Append(c);
                if ((++count % 5) == 0)
                {
                    builder.Append('-');
                }
            }
            Console.WriteLine("Before: {0}", alpha);
            alpha = builder.ToString();
            Console.WriteLine("After: {0}", alpha);
        }
    }
}