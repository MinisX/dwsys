using System;
using System.Threading;

namespace timeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start;
            DateTime end;
            System.Console.WriteLine("start");
            start = DateTime.Now;
            Thread.Sleep(1000);
            end = DateTime.Now;
            System.Console.WriteLine("stop");
            System.Console.WriteLine($"time elapsed = {end-start}");
        }
    }
}
