using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split('|').ToArray();
            decimal budget = decimal.Parse(Console.ReadLine());
            List<decimal> prices = new List<decimal>();
            decimal initialSum = 0;
            decimal finalSum = 0;
            
            for (int i = 0; i < items.Length; i++)
            {
                string[] data = items[i].Split("->").ToArray();
                string item = data[0];
                decimal price = decimal.Parse(data[1]);
                

                if (item == "Clothes")
                {
                    if (budget >= price)
                    {
                        if (price > 50.00m)
                        {
                            continue;
                        }
                        else
                        {
                            budget = budget - price;
                            initialSum = initialSum + price;
                            price = price * 1.4m;
                            finalSum = finalSum + price;
                            prices.Add(price);
                        }
                    }
                }
                else if (item == "Shoes")
                {
                    if (budget >= price)
                    {
                        if (price > 35.00m)
                        {
                            continue;
                        }
                        else
                        {
                            budget = budget - price;
                            initialSum = initialSum + price;
                            price = price * 1.4m;
                            finalSum = finalSum + price;
                            prices.Add(price);
                        }
                    }
                }
                else if (item == "Accessories")
                {
                    if (budget >= price)
                    {
                        if (price > 20.50m)
                        {
                            continue;
                        }
                        else
                        {
                            budget = budget - price;
                            initialSum = initialSum + price;
                            price = price * 1.4m;
                            finalSum = finalSum + price;
                            prices.Add(price);
                        }
                    }
                }
            }//end of for loop
            decimal final = budget + finalSum;
            for (int i = 0; i < prices.Count; i++)
            {
                Console.Write($"{prices[i]:F2} ");
            }

            Console.WriteLine();
            if (final >= 150)
            {
                decimal profit = finalSum - initialSum;
                Console.WriteLine("Profit: {0:F2}",profit);
                Console.WriteLine("Hello, France!");
            }
            else if (final < 150)
            {
                decimal profit = finalSum - initialSum;
                Console.WriteLine("Profit: {0:F2}", profit);
                Console.WriteLine("Time to go.");
            }
        }
    }
}
