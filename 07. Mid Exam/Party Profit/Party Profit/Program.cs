using System;

namespace Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int total = days * 50;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                { 
                    partySize = partySize - 2;
                }
                if (i % 15 == 0)
                {
                    partySize = partySize + 5;
                }
                
                if (i % 3 == 0)
                {
                    total = total - partySize * 3;
                }
                if (i % 5 == 0)
                {
                    total = total + partySize * 20;
                    if (i % 3 == 0)
                    {
                        total = total - partySize * 2;
                    }
                }
                total = total - partySize * 2;
            }
            total = total / partySize;
            Console.WriteLine("{0} companions received {1} coins each.", partySize,total);
        }
    }
}
