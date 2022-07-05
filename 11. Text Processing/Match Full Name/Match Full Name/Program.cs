using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var text = Console.ReadLine();

        var pattern = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+\b)");

        MatchCollection matches = pattern.Matches(text);


        foreach (Match item in matches)
        {
            Console.Write("{0} ", string.Join(" ", item));
        }

    }
}