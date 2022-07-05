using System;
using System.Globalization;

namespace Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            DateTime dayWeek = new DateTime();
            dayWeek = DateTime.ParseExact(day, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dayWeek.DayOfWeek);
        }
    }
}
