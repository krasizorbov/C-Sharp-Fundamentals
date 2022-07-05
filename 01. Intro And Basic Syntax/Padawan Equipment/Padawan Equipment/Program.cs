using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());
            double total = 0;
            int lightsabersNumber = (int)Math.Ceiling((students * 0.1 + students));

         
            double beltsNumber = students / 6.00;
            //if (students % 6 >= 5)
            //{
                //beltsNumber = students / 6 + 1;
            //}
            if (beltsNumber >= 6)
            {
                beltsNumber = students - beltsNumber;
                total = lightsabers * lightsabersNumber + robes * students + belts * beltsNumber;
                if (money >= total)
                {
                    Console.WriteLine("The money is enough - it would cost {0:F2}lv.", total);
                }
                else
                {
                    double moneyNeeded = total - money;
                    Console.WriteLine("Ivan Cho will need {0:F2}lv more.", moneyNeeded);
                }
            }
            else
            {
                total = lightsabers * lightsabersNumber + robes * students + belts * students;
                if (money >= total)
                {
                    Console.WriteLine("The money is enough - it would cost {0:F2}lv.", total);
                }
                else
                {
                    double moneyNeeded = total - money;
                    Console.WriteLine("Ivan Cho will need {0:F2}lv more.", moneyNeeded);
                }
            }            
        }
    }
}
