using BenchmarkDotNet.Running;

namespace Drecom.Clipper2Lib.Benchmark
{
    public class Program
    {        
        public static void Main()
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}