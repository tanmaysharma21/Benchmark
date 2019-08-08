using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace BenchmarkingLib
{
    public class Program1
    {
        static void Main(string[] args)
        {
            var benchmark = BenchmarkRunner.Run<Program1>();
        }

        [Benchmark]
        public void StringBenchMark()
        {
            string s = "Time";
            for (int i = 0; i < 100; i++)
            {
                s = s + " is 4";
            }
        }

        [Benchmark]
        public void StringBuilderBenchMark()
        {
            StringBuilder sb = new StringBuilder("Time");
            for (int i = 0; i < 100; i++)
            {
                sb.Append(" is 4");
            }
        }
    }
}
