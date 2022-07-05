using System;
using System.Linq;


namespace Advertisement_message
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < num; i++)
            {
                var indexPhrases = new Random().Next(phrases.Length);
                var indexEvents = new Random().Next(events.Length);
                var indexAuthors = new Random().Next(authors.Length);
                var indexCities = new Random().Next(cities.Length);
                Console.WriteLine($"{phrases[indexPhrases]} {events[indexEvents]} {authors[indexAuthors]} - {cities[indexCities]}");
            }
        }
    }
}
