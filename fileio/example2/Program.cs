using System;
using System.IO;

namespace example1
{
    class Program
    {
        // Store the filename in static string variable
        static string filename = "test.txt";
        static void Main(string[] args)
        {
            // Splits the file into array of strings based on newline
            String[] lines = File.ReadAllLines(filename);
            // This will be line numbers
            int n = 0;
            foreach (var l in lines)
            {
                // Print lines with line numbers
                Console.WriteLine($"{n++} {l}");
            }
        }
    }
}
