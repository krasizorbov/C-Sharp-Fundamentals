using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        if (number >= 30)
                        {
                            price = number * 8.45;
                            price = price - price * 0.15;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 8.45;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    if (type == "Business")
                    {
                        if (number >= 100)
                        {
                            price = (number - 10) * 10.90;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 10.90;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    if (type == "Regular")
                    {
                        if (number >= 10 && number <= 20)
                        {
                            price = number * 15.00;
                            price = price - price * 0.05;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 15.00;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        if (number >= 30)
                        {
                            price = number * 9.80;
                            price = price - price * 0.15;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 9.80;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    if (type == "Business")
                    {
                        if (number >= 100)
                        {
                            price = (number - 10) * 15.60;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 15.60;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    if (type == "Regular")
                    {
                        if (number >= 10 && number <= 20)
                        {
                            price = number * 20.00;
                            price = price - price * 0.05;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 20.00;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        if (number >= 30)
                        {
                            price = number * 10.46;
                            price = price - price * 0.15;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 10.46;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    if (type == "Business")
                    {
                        if (number >= 100)
                        {
                            price = (number - 10) * 16.00;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 16.00;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    if (type == "Regular")
                    {
                        if (number >= 10 && number <= 20)
                        {
                            price = number * 22.50;
                            price = price - price * 0.05;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                        else
                        {
                            price = number * 22.50;
                            Console.WriteLine("Total price: {0:F2}", price);
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
