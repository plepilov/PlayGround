using System;
using Xunit;

namespace MessageParser.Tests
{
    public class ParserTests
    {
        [Fact]
        public void SimpleParse()
        {
            Assert.Equal(2, MessageParser.Parse("Sample Message").Length);
        }
        
        [Fact]
        public static void SpanSplitParse()
        {
            ReadOnlySpan<char> value = "Sample Message";

            var expected = value.ToString().Split(' ');
            var idx = 0;
            foreach (var segment in value.Split(' '))
            {
                Assert.Equal(expected[idx++], value[segment].ToString());
            }
        }
    }
}