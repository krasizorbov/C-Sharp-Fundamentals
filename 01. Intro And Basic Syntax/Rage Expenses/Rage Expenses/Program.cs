using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double brokenHeadset = gamesLost / 2;
            double brokenMouse = gamesLost / 3;
            double brokenKeyboard = gamesLost / 6;
            double brokenDisplay = gamesLost / 12;
            double total = brokenHeadset * headsetPrice + brokenMouse * mousePrice + brokenKeyboard * keyboardPrice + brokenDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
