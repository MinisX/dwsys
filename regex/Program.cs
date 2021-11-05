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
            // regular expression for exactly any 5 characters - ^.{5}$
            // regular expression which start with character 'h' and then has exactly 4 characters - ^h.{4}$
            Regex re = new("^h.{4}$");
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
