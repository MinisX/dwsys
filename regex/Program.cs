using System;
using System.IO;
using System.Text.RegularExpressions;

// Regex = regular expressions
namespace regex
{
    class Program
    {
        static string filename = "test.txt";
        static void Main(string[] args)
        {
            String[] lines = File.ReadAllLines(filename);
            Regex re = new("abc");
            foreach (var line in lines)
            {
                // similar to 'line.Contains("abc")'
                if(re.IsMatch(line)){
                    System.Console.WriteLine(line);
                }
            }
        }
    }
}
