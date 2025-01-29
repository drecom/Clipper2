using BenchmarkDotNet.Running;

namespace Drecom.Clipper2Lib.Benchmark
{
    public static class Program
    {        
        public static void Main()
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}