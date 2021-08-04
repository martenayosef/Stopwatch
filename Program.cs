using System;


namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            switchStopWach();

        }

         static void switchStopWach()
        {
            var stopwatch = new StopWatch();
            while (true)
            {
                Console.Write("Enter b for start, or s for stop, or any other charater to exsit: ");
                var input = Console.ReadLine();

                if (input == "b")
                {
                    stopwatch.Start();
                }
                else if (input == "s")
                {
                    stopwatch.Stop();
                    Console.WriteLine("duration is " + stopwatch.GetDuration());
                }
                else
                {
                    Console.WriteLine("duration is " + stopwatch.GetDuration());
                    break;
                }
            }
        }
    }
}
