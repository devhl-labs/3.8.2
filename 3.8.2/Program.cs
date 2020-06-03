using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            do
            {
                Console.WriteLine("Enter a phrase or use 'exit' or 'read'.");

                input = Console.ReadLine().ToLower();

                if (input == "exit")
                    return;

                if (input == "read")
                    input = File.ReadAllText("read.txt");

                Dictionary<char, int> counts = new Dictionary<char, int>();

                foreach(char c in input.ToCharArray().Where(c => char.IsLetter(c)))
                {
                    counts[c] = input.Count(character => character == c);
                }

                foreach (var entry in counts)
                    Console.WriteLine(entry.Key + " " + entry.Value);


            } while (input != "exit");
        }
    }
}
