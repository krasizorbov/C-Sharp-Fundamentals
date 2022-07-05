using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            double outfall4 = 39.99;
            double scog = 15.99;
            double zplinterZell = 19.99;
            double honored2 = 59.99;
            double roverWatch = 29.99;
            double roverWatchOE = 39.99;
            double balance = money;


            string input = string.Empty;

            while (input != "Game Time")
            {
                input = Console.ReadLine();

                if (input == "OutFall 4" || input == "CS: OG" || input == "Zplinter Zell" || input == "Honored 2" || input == "RoverWatch" || input == "Game Time" || input == "RoverWatch Origins Edition")
                {
                    switch (input)
                    {
                        case ("OutFall 4"):

                            if (input == "OutFall 4")
                            {
                                if (balance >= outfall4)
                                {
                                    Console.WriteLine("Bought OutFall 4");
                                    balance = balance - 39.99;
                                }
                                else if (balance < outfall4)
                                {
                                    Console.WriteLine("Too Expensive");
                                }  
                            }
                            break;

                        case ("CS: OG"):

                            if (input == "CS: OG")
                            {
                                if (balance >= scog)
                                {
                                    Console.WriteLine("Bought CS: OG");
                                    balance = balance - 15.99;
                                }
                                else if (balance < scog)
                                {
                                    Console.WriteLine("Too Expensive");
                                }  
                            }
                            break;

                        case ("Zplinter Zell"):

                            if (input == "Zplinter Zell")
                            {
                                if (balance >= zplinterZell)
                                {
                                    Console.WriteLine("Bought Zplinter Zell");
                                    balance = balance - 19.99;
                                }
                                else if (balance < zplinterZell)
                                {
                                    Console.WriteLine("Too Expensive");
                                }  
                            }
                            break;

                        case ("Honored 2"):

                            if (input == "Honored 2")
                            {
                                if (balance >= honored2)
                                {
                                    Console.WriteLine("Bought Honored 2");
                                    balance = balance - 59.99;
                                }
                                else if (balance < honored2)
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                            }
                            break;

                        case ("RoverWatch"):

                            if (input == "RoverWatch")
                            {
                                if (balance >= roverWatch)
                                {
                                    Console.WriteLine("Bought RoverWatch");
                                    balance = balance - 29.99;
                                }
                                else if (balance < roverWatch)
                                {
                                    Console.WriteLine("Too Expensive");
                                } 
                            }
                            break;

                        case ("RoverWatch Origins Edition"):

                            if (input == "RoverWatch Origins Edition")
                            {
                                if (balance >= roverWatchOE)
                                {
                                    Console.WriteLine("Bought RoverWatch Origins Edition");
                                    balance = balance - 39.99;
                                }
                                else if (balance < roverWatchOE)
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                            }
                            break;
                        default:
                            break;
                    }  
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            double moneyLeft = money - balance; 
            Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", moneyLeft, balance);
         }
    }
}
