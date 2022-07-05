using System;

namespace Coocking_masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());
        

            double total = 0;

            int freePacage = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freePacage++;
                }
            }

            total = (students - freePacage) * flourPrice + students * eggPrice * 10 + apronPrice * Math.Ceiling(students * 1.2);


            if (total <= budget)
            {
                Console.WriteLine($"Items purchased for {total:F2}$.");
            }
            else
            {
                double moneyNeeded = total - budget;
                Console.WriteLine($"{moneyNeeded:F2}$ more needed.");
            }
        }
    }
}
