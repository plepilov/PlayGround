using System;
using System.Collections.Generic;

namespace MessageParser
{
    public class MessageParser
    {
        public static string[] Parse(string message)
        {
            return message.Split();
        }
        
        public static string[] ParseSpan(string message)
        {
            var ret = new List<string>();
            var value = message.AsSpan();
            foreach (var segment in value.Split(' '))
            {
                ret.Add(value[segment].ToString());
            }
            return ret.ToArray();
        }
    }
}