using System;
using System.Diagnostics;
using System.Threading;

namespace timeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new();
            System.Console.WriteLine("start");
            s.Start();
            Thread.Sleep(1000);
            s.Stop();
            System.Console.WriteLine("stop");
            System.Console.WriteLine($"time elapsed = {s.Elapsed}");
        }
    }
}
