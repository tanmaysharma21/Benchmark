using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace ArrayVsList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var benchmark = BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public void ArrayBenchmark()
        {
            int[] array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = i;
            }
            for (int i = 0; i < 100; i++)
            {
                int x = array[i];
            }
        }

        [Benchmark]
        public void ListBenchmark()
        {
            List < int > list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list[i] = i;
            }
            for (int i = 0; i < 100; i++)
            {
                int x = list[i];
            }
        }

    }
}
