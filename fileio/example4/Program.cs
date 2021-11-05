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
        // FileStream is a stream of bytes
        using (FileStream rd = File.Open(fname, FileMode.Open))
        {
            
            while(true){
                // When we want to read bytes, we have to provide byte array
                // and then we want to read our data into byte array
                int max = 1000;
                int n;
                byte[] data = new byte[max];   
                // Here we read byte by byte into byte array
                // Return is the number of bytes, which we store in 'n'
                n = rd.Read(data, 0, max);
                if(n==0) break; // break the loop if there is no more data left to read
                
                // Convert byte array into stream
                // our file uses UTF8 encoding, so we use UTF8
                String line = Encoding.UTF8.GetString(data, 0, n);
                Console.WriteLine(line);
            }
        }
    }
}