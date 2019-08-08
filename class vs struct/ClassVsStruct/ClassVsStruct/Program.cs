using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace ClassVsStruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            var benchmark = BenchmarkRunner.Run<Program>();

        }

        [Benchmark]
        public void StructBenchmark()
        {
            StructEmployee emp = new StructEmployee() ;
            emp.EmpId = 101;
            emp.FirstName = "Tanmay";
            emp.LastName = "Sharma";
            Console.WriteLine(emp.EmpId+" "+emp.FirstName+" "+emp.LastName);
        }

        [Benchmark]
        public void ClassBenchmark()
        {
            ClassEmployee emp = new ClassEmployee();
            emp.EmpId = 101;
            emp.FirstName = "Tanmay";
            emp.LastName = "Sharma";
            Console.WriteLine(emp.EmpId + " " + emp.FirstName + " " + emp.LastName);
        }

    }

    public struct StructEmployee
    {
        public int EmpId;
        public string FirstName;
        public string LastName;
    }

    public class ClassEmployee
    {
        public int EmpId;
        public string FirstName;
        public string LastName;
    }
}
