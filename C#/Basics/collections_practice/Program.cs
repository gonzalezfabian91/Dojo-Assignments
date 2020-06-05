using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfInts = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            {
                Console.WriteLine(arrOfInts[8]);
            }
            string[] peoples = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            {
                Console.WriteLine(peoples[2]);
            }
            string[] true_false = new string[] {"true", "false", "true", "false", "true", "false", "true", "false", "true", "false"};
            foreach (string word in true_false)
            {
                Console.WriteLine($"{word}");
            }

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Fudge");
            flavors.Add("Cheesecake");
            {
                Console.WriteLine(flavors.Count);
                Console.WriteLine(flavors[2]);
            }
            flavors.Remove("Strawberry");
            {
                Console.WriteLine(flavors.Count);
            }

            Dictionary<string,string> profile = new Dictionary<string, string>();
            foreach (var people in peoples)
            {
                profile.Add(people, null);
            }
            Random rand = new Random();
            foreach (var people in peoples)
            {
                int randflv = rand.Next(flavors.Count - 1);
                profile[people] = flavors[randflv];
                flavors.RemoveAt(randflv);
            }
            foreach (var entry in profile)
            {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value);
            }
        }
    }
}
