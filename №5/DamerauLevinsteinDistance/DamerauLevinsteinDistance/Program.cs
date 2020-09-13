using System;
using VagnerFisherAlgorithmlib;
using System.IO;
using System.Collections.Generic;

namespace DamerauLevinsteinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileText = new List<string>();
            string[] text = File.ReadAllText("1.txt").Split(' ');
            foreach (string i in text)
                if (!fileText.Contains(i))
                    fileText.Add(i);
            string word = Console.ReadLine();
            Console.WriteLine("\n----------------------\n");
            foreach (string i in fileText)
                Console.WriteLine("match score: {0}\n-------------------------------------\n", 
                    100 - (double)100.0 / (word.Length > i.Length ? word.Length : i.Length) * LevinsteinVagner.CalculateDistance(i, word));
            Console.WriteLine("Hello World!");
        }
    }
}
