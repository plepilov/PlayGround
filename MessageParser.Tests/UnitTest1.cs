using System;
using Xunit;

namespace MessageParser.Tests
{
    public class ParserTests
    {
        [Fact]
        public void SimpleParse()
        {
            MessageParser parser = new();
            Assert.Equal(2, parser.Parse("Sample Message").Length);
        }
        
        [Fact]
        public static void SpanSplitParse()
        {
            ReadOnlySpan<char> value = "Sample Message";

            var expected = value.ToString().Split(' ');
            var enumerator = value.Split(' ');
            Assert.True(enumerator.MoveNext());
            Assert.Equal("Sample", value[enumerator.Current].ToString());
            Assert.True(enumerator.MoveNext());
            Assert.Equal("Message", value[enumerator.Current].ToString());

            var idx = 0;
            foreach (var segment in value.Split(' '))
            {
                Assert.Equal(expected[idx++], value[segment].ToString());
            }
        }
    }
}