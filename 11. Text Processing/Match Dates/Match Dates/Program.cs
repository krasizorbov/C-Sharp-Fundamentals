using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 
namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
    
            var pattern = @"\b(?<day>\d{2})([.\/-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            // var pattern = @"\b(?<day>\d{2})([.\/-])(?<month>[A-Z][a-z]{2})    \2 /* трябва да е \1 a не \2 */    (?<year>\d{4})\b";

            // Since RegEx works differently across different languages, before we continue
            //, we’re going to set our backreference from \2 to \1.
            //This is because C# backreferences don’t count named capture groups for backreferences.
            //So, change it before we continue.

            string datesString = Console.ReadLine();

            MatchCollection dates = Regex.Matches(datesString, pattern);

            foreach (Match date in dates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}