using Nessos.LinqOptimizer.CSharp;
using System;
using System.Diagnostics;
using System.Linq;

namespace RealWorld
{
    public class PerformanceExamples
    {
        public static void Start()
        {
            var size = 10000000;
            var stopwatch = new Stopwatch();

            #region LINQ

            stopwatch.Restart();
            var q1 = Enumerable.Range(1, size)
                .Select(n => n * 2)
                .Select(n => Math.Sin((2 * Math.PI * n) / 100))
                .Select(n => Math.Pow(n, 2))
                .Sum();
            stopwatch.Stop();
            Console.WriteLine("LINQ {0} items in {1}ms", size, stopwatch.ElapsedMilliseconds);

            #endregion

            #region for

            stopwatch.Restart();
            var sum = 0d;
            for (var i = 1; i <= size; i++)
            {
                var a = i * 2;
                var b = Math.Sin((2 * Math.PI * i) / 100);
                var c = Math.Pow(i, 2);
                sum += c;
            }
            stopwatch.Stop();
            Console.WriteLine("for Loop {0} items in {1}ms", size, stopwatch.ElapsedMilliseconds);

            #endregion

            #region LinqOptimizer

            var q2 = Enumerable.Range(1, size).AsQueryExpr()
                           .Select(n => n * 2)
                           .Select(n => Math.Sin((2 * Math.PI * n) / 100))
                           .Select(n => Math.Pow(n, 2))
                           .Sum();

            q2.Compile();

            stopwatch.Restart();
            var r = q2.Run();
            stopwatch.Stop();
            Console.WriteLine("LINQ Optimizer {0} items in {1}ms", size, stopwatch.ElapsedMilliseconds);

            #endregion

            #region PLINQ

            stopwatch.Restart();
            var q3 = Enumerable.Range(1, size).AsParallel()
                .Select(n => n * 2)
                .Select(n => Math.Sin((2 * Math.PI * n) / 100))
                .Select(n => Math.Pow(n, 2))
                .Sum();
            stopwatch.Stop();
            Console.WriteLine("PLINQ {0} items in {1}ms", size, stopwatch.ElapsedMilliseconds);

            #endregion
        }
    }
}