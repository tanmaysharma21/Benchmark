using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(SaveData);
            var t2 = new Thread(PrintData);
            t1.Start();
            t2.Start();

        }

        public static void SaveData()
        {
            Thread.Sleep(4000);
        }

        public static void PrintData()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hi");
        }

    }
}
