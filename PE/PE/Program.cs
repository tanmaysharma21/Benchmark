using System;
using System.Diagnostics;
using System.Text;

namespace PE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.StringVsStringBuilder();
        }

        public void StringVsStringBuilder()
        {
            var watch = new Stopwatch();

            string s = "Time";
            StringBuilder sb = new StringBuilder("Time");
            watch.Start();
            for (int i = 0; i < 100; i++)
            {
                s = s + " is 4";
            }
            Console.WriteLine($"Time elapsed for string is {watch.ElapsedTicks}");
            watch.Reset();
            watch.Start();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(" is 4");
            }
            Console.WriteLine($"Time elapsed for string buiilder is {watch.ElapsedTicks}");

        }

        public void StringBenchMark()
        {
            string s = "Time";
            for (int i = 0; i < 100; i++)
            {
                s = s + " is 4";
            }
        }

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
