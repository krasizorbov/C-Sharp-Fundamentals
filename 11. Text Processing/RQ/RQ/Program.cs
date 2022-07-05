using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace ExamPreparation
{
    public sealed class Preparation
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(([^\d]+)(\d+))";
            int count = 0;

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            StringBuilder output = new StringBuilder();

            foreach (Match match in matches)
            {
                string message = match.Groups[2].Value;
                int repeats = int.Parse(match.Groups[3].Value);

                for (int i = 0; i < repeats; i++)
                {
                    output.Append(message.ToUpper());
                }
            }

            count = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(output);
        }
    }
}