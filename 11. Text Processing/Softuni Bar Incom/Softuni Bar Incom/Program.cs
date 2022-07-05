using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Softuni_Bar_Incom
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalIncom = 0.0;

            string input = string.Empty;

            while (input != "end of shift")
            {
                input = Console.ReadLine();

                string pattern = @"%(?<person>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d+)\$";

                Match m = Regex.Match(input, pattern);

                if (m.Success)
                {
                    string customerName = m.Groups["person"].Value;
                    
                    string product = m.Groups["product"].Value;

                    int count = int.Parse(m.Groups["count"].Value);

                    double price = double.Parse(m.Groups["price"].Value);

                    double totalPrice = price * count;

                    totalIncom += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                }
            }

           Console.WriteLine("Total income: {0:F2}", totalIncom);
        }
    }
}
