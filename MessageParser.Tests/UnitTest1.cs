using System;
using Xunit;

namespace MessageParser.Tests
{
    public class ParserTests
    {
        [Fact]
        public void SimpleParse()
        {
            var expected = "Sample Message".Split(' ');
            var idx = 0;
            foreach (var item in "Sample Message".Split(' '))
            {
                Assert.Equal(expected[idx++], item);
            }
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