using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<Dictionary<string, string>> planetProbes = new List<Dictionary<string, string>>();
            planetProbes.Add(new Dictionary<string, string>() { { "BepiColombo", "Mercury" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Messenger", "Mercury" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mariner 10", "Mercury" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Venus Express", "Venus" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Akatsuki", "Venus" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Satelite", "Earth" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Insight", "Mars" } });
            planetProbes.Add(new Dictionary<string, string>() { { "MAVEN", "Mars" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mangalyaan", "Mars" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Cassini", "Jupiter" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Galileo", "Jupiter" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Cassini", "Saturn" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Hyugens", "Saturn" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Voyager 2", "Saturn" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Voyager 2", "Uranus" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Voyager 2", "Neptune" } });


            foreach (string planet in planetList)
            {
                List<string> matchingProbes = new List<string>();

                foreach (Dictionary<string, string> probe in planetProbes)
                {
                    foreach (KeyValuePair<string, string> pair in probe)
                        // Console.WriteLine($"key: {pair.Key} / value: {pair.Value}");

                        if (planet == pair.Value)
                        {
                            matchingProbes.Add(pair.Key);
                        }
                }
                Console.WriteLine($"{planet}: {String.Join(" ", matchingProbes)}");
            }
        }
    }
}
