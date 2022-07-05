using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Valid_Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] user = Console.ReadLine().Split(", ").ToArray();

            string number = "";
            string symbol1 = "";
            string yes = "";
            for (int k = 0; k < user.Length; k++)
            {
                if (user[k].Length >= 3 && user[k].Length <= 16)
                {
                    number = "1";
                }
                else
                {
                    number = "2";
                }

                if (user[k].Contains("-") || user[k].Contains("_"))
                {
                    symbol1 = "1";
                }
                else
                {
                    symbol1 = "2";
                }

                for (int j = 0; j < user[k].Length; j++)
                {
                    if (char.IsLetterOrDigit(user[k][j]))
                    {
                        yes = "1";
                    }
                    else
                    {
                        if (user[k][j] == '-' || user[k][j] == '_')
                        {
                            yes = "1";
                        }
                        else
                        {
                            yes = "2";
                            break;
                        }   
                    }
                }
                if (number == "1" && yes == "1")
                {
                    if (symbol1 == "1")
                    {
                        Console.WriteLine(user[k]);
                    }
                    else
                    {
                        Console.WriteLine(user[k]);
                    }
                }
            }  
        }
    }
}
