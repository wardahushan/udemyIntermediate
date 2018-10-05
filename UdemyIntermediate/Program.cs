using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunStopWatchExercise(); 



        }

        private static void RunStopWatchExercise()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();

            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            stopwatch.Stop();

            Console.WriteLine($"Elapsed time(s) are:");
            foreach (TimeSpan duration in stopwatch.Durations())
            {
                Console.WriteLine(duration);
            }
        }
    }
}
