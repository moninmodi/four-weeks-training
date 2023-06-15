using System.Diagnostics;

namespace AsyncAwaitBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Call PerformCalculations and measure time taken using Stopwatch
            
            await PerformCalculations(10);

        }

        static async Task SimulateLongRunningTask(int delayInSeconds)
        {
            await Task.Delay(delayInSeconds*1000);
        }

        static async Task PerformCalculations(int numberOfTasks)
        {
            // Start long-running tasks concurrently and wait for them to complete
            Stopwatch sw = Stopwatch.StartNew();
            Task[] tasks = new Task[numberOfTasks];
            for (int i=0;i<numberOfTasks; i++)
            {
                tasks[i] = SimulateLongRunningTask(5);
            }
            await Task.WhenAll(tasks);
            sw.Stop();
            Console.WriteLine($"Time taken to complete {numberOfTasks} tasks: {sw.Elapsed.TotalSeconds}");
        }
    }
}