using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace ForVsForEach
{
    public class Program
    {
        static void Main(string[] args)
        {
            var benchmark = BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public void ForLoopBenchMarking()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.Write(list[i]);
            }
        }

        [Benchmark]
        public void ForEachLoopBenchMarking()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            foreach (int item in list)
            {
                Console.Write(item);
            }
        }

    }
}
