using BenchmarkDotNet.Attributes;

namespace ParserBenchmark
{
    [MemoryDiagnoser]
    public class ParserBenchMarks
    {
        private readonly string data = "asd dfgh rtyertyem ertyerywerdgw wetw56w5r vbnmvbnm";

        [Benchmark]
        public string[] ParseRegular() => MessageParser.MessageParser.Parse(data);

        [Benchmark]
        public string[] ParseSpan() => MessageParser.MessageParser.ParseSpan(data);
    }
}
