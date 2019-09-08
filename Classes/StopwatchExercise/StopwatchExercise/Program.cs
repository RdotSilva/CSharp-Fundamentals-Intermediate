using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            Console.WriteLine("Press ENTER to start timer and ENTER to stop timer.");
            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    stopWatch.StartTimer();
                    Console.ReadLine();
                    stopWatch.StopTimer();
                    Console.WriteLine(stopWatch.Duration().TotalSeconds + " seconds elapsed.");
                    continue;
                }

                break;
            }
        }
    }
}
