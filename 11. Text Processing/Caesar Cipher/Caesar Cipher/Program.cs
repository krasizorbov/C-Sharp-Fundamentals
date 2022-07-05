using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
               
                if (text[i] + 3 > 127)
                {
                    newText = newText + (char)(32 + text[i] + 3 - 127);
                }
                else
                {
                    newText = newText + (char)(text[i] + 3);
                }
            }
            Console.WriteLine(newText);
        }
    }
}
