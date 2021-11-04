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
            // This reads all context of the file and then we output it to the terminal
            Console.WriteLine(File.ReadAllText(filename));
        }
    }
}
