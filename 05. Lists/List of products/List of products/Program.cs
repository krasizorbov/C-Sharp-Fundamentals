using System;
using System.Linq;
using System.Collections.Generic;

namespace List_of_products
{
    class Program
    {
        static void Main(string[] args)
        {
            int productNumber = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < productNumber; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + products[i]);
            }
        }
    }
}
