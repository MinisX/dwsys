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
        // using checks if the object goes out of scope and if it does, then it called Dispose method, in which the file is closed
        using (StreamReader rd = File.OpenText(fname))
        {
            // While not at the end of the stream, read the next line
            while (!rd.EndOfStream)
            {
                string line = rd.ReadLine();
                // output the line
                Console.WriteLine(line);
            }
        }
    }
}