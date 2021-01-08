using System;
using System.Collections.Generic;

namespace MessageParser
{
    public class MessageParser
    {
        private static string[] result = new [] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};
        public static string[] Parse(string message)
        {
            var index = 0;
            foreach (var item in message.Split())
            {
                result[index] = item;
            }

            return result;
        }
        
        public static string[] ParseSpan(string message)
        {
            var value = message.AsSpan();
            var index = 0;
            foreach (var segment in value.Split(' '))
            {
                result[index] = value[segment].ToString();
            }

            return result;
        }
    }
}