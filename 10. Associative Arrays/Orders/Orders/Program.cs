using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();

            Dictionary<string, int> productQuantity = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "buy")
            {
                string product = input[0];
                decimal price = decimal.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!productPrice.ContainsKey(product))
                {
                    productPrice.Add(product, price);
                    productQuantity.Add(product, quantity);
                }
                else
                {
                    productPrice[product] = price;
                    productQuantity[product] = productQuantity[product] + quantity;
                }

                input = Console.ReadLine().Split().ToArray();

            }//while loop ends here.

            foreach (var item in productPrice)
            {
                foreach (var item1 in productQuantity)
                {
                    if (item.Key == item1.Key)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value * item1.Value:F2}");

                    }
                }   
            }
        }
    }
}
