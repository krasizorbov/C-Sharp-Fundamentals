using System;

namespace Password_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!PasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!NumberLetters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!NumberDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (PasswordLength(password) && NumberDigits(password) && NumberLetters(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool PasswordLength(string password)
        {
            
            if (password.Length < 6 || password.Length > 10)
            {   
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NumberDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter < 2 )
            {  
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NumberLetters(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter < password.Length)
            { 
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
