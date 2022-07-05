using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                string patternName = @"@(?<name>\w+)\|";

                Match mName = Regex.Match(input, patternName);

                string name = string.Empty;

                if (mName.Success)
                {
                    name = mName.Groups["name"].Value;
                }

                string patternAge = @"#(?<age>\d+)\*";

                Match mAge = Regex.Match(input, patternAge);

                string age = string.Empty;

                if (mAge.Success)
                {
                    age = mAge.Groups["age"].Value;

                }
                int agee = int.Parse(age);
                Console.WriteLine($"{name} is {agee} years old.");
            }
        }
    }
}
