using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = string.Empty;
            string end = string.Empty;
            string input = string.Empty;
            decimal sum = 0;
            decimal coins;
            
            while (true)
            {
                label:
                coins = 0;
                input = Console.ReadLine();
                
                bool success = decimal.TryParse(input, out coins);
                if (success)
                {
                    if (coins == 0.10m || coins == 0.20m || coins == 0.50m || coins == 1.00m || coins == 2.00m)
                    {
                        sum = sum + coins;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                    }
                }
                else
                {
                    if (input == "Nuts" || input == "Water" || input == "Crisps" || input == "Soda" || input == "Coke" || input == "Start")
                    {
                        if (input == "Start")
                        {
                            goto label;
                        }
                        switch (input)
                        {
                            case "Nuts":
                                if (sum < 2m)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                else
                                {
                                    sum = sum - 2.0m;
                                    Console.WriteLine($"Purchased {input.ToLower()}");
                                }
                                break;
                            case "Water":
                                if (sum < 0.7m)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                else
                                {
                                    sum = sum - 0.7m;
                                    Console.WriteLine($"Purchased {input.ToLower()}");
                                }
                                break;
                            case "Crisps":
                                if (sum < 1.5m)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                else
                                {
                                    sum = sum - 1.5m;
                                    Console.WriteLine($"Purchased {input.ToLower()}");
                                }
                                break;
                            case "Soda":
                                if (sum < 0.8m)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                else
                                {
                                    sum = sum - 0.8m;
                                    Console.WriteLine($"Purchased {input.ToLower()}");
                                }
                                break;
                            case "Coke":
                                if (sum < 1.0m)
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                else
                                {
                                    sum = sum - 1.0m;
                                    Console.WriteLine($"Purchased {input.ToLower()}");
                                }
                                break;
                            //default:
                                //Console.WriteLine("Invalid product");
                                //break;
                        }
                    }
                    else if (input == "End")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }
            }
            Console.WriteLine("Change: {0:F2}", sum);
        }
    }
}
