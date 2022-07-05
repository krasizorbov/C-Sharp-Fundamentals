using System;

namespace Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayofWeek = int.Parse(Console.ReadLine());
            string[] arr = new string[7] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            foreach (var item in arr)
            {
                if (dayofWeek > 7 || dayofWeek <= 0)
                {
                    Console.WriteLine("Invalid day!");
                    break;
                }
                else if (arr[dayofWeek - 1] == item)
                {
                    Console.WriteLine(item);
                    break;
                } 
            }
        }
    }
}
