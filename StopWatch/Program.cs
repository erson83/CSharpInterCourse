using System;
using System.Diagnostics;
// test 1
namespace StopwatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Code to measure duration
            stopwatch.Stop();
            Console.WriteLine("Duration: " + stopwatch.GetDuration().ToString());

            // Start and stop again
            stopwatch.Start();

            // Code to measure duration
            stopwatch.Stop();
            Console.WriteLine("Duration: " + stopwatch.GetDuration().ToString());
        }
    }
}
