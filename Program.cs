using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>() {
                "Mercury", "Mars"
                };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            List<string> lastTwoPlanets = new List<string>() {
                "Uranus", "Neptune"
            };
            lastTwoPlanets.Add("Pluto");
            planetList.AddRange(lastTwoPlanets);

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            // rockyPlanets.ForEach(rp => Console.WriteLine(rp));

            planetList.Remove("Pluto");

            // planetList.ForEach(planet => Console.WriteLine(planet));

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i=0; i<numbers.Count; i++) {
                if (numbers.Contains(i)) {
                    Console.WriteLine("numbers list contains " + i );
                } else {
                    Console.WriteLine("numbers list does not contain " + i);
                }
            // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
   
            }
        }
    }
}
