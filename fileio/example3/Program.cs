using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        string fname = @"test.txt";
        // StreamReader reads file line by line
        using (StreamReader rd = File.OpenText(fname))
        {
            // While not at the end of the stream, read the next line
            while (!rd.EndOfStream)
            {
                string line = rd.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}