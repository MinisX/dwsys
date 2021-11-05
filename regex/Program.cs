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
            Regex re = new("^X(abc.)(abc.)");
            foreach (var line in lines)
            {
                // this data type contains all possible mathces and submatches and groupmatches
                Match m = re.Match(line);
                if(m.Success){
                    foreach (var item in m.Groups)
                    {
                        System.Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
