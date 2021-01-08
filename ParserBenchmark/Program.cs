using BenchmarkDotNet.Running;

namespace ParserBenchmark
{
    static class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ParserBenchMarks>();        
        }
    }
}