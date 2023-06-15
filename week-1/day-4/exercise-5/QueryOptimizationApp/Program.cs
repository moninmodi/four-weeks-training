using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace QueryOptimizationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> data = GenerateRandomNumbers(10000000);
            Stopwatch sw = Stopwatch.StartNew();

            // Original query
            var originalQuery = data.AsParallel()
                                    .Where(x => x > 100)
                                    .OrderByDescending(x => x)
                                    .Take(10)
                                    .ToList();
            sw.Stop();
            Console.WriteLine("Original Query: {0} ms", sw.ElapsedMilliseconds);

            // Optimized query
            sw.Restart();
            // Add your optimized query here

            sw.Stop();
            Console.WriteLine("Optimized Query: {0} ms", sw.ElapsedMilliseconds);
        }

        static IEnumerable<int> GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next();
                yield return randomNumber;
            }
        }
    }
}
