using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingBenchMark
{
    public class Program
    {
        static void Main(string[] args)
        {
            var benchmark = BenchmarkRunner.Run<Program>();

        }

        //[Benchmark]
        public static void SaveData1()
        {
            Thread.Sleep(4000);
        }

        //[Benchmark]
        public static void PrintData1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hi");
        }

        [Benchmark]
        public void ThreadCalling()
        {
            var t1 = new Thread(SaveData1);
            var t2 = new Thread(PrintData1);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        [Benchmark]
        public void ExecuteWithTasks()
        {

            Task.Run(async () =>
            {
                var task1 = SaveData();
                var task2 = PrintData();
                await Task.WhenAll(task1, task2);
            }).GetAwaiter().GetResult();


        }

        public async static Task SaveData()
        {
            //Thread.Sleep(4000);
            await Task.Delay(4000);
            //Console.WriteLine("SaveData");

        }

        public async static Task PrintData()
        {

            //Thread.Sleep(3000);
            await Task.Delay(4000);
            //Console.WriteLine("PrintData");
        }

    }
}
