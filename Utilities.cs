using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCPAsync
{
    abstract class Utilities
    {
        public static byte[] GetBytesFromString(String str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }
        public static String GetStringFromBytes(byte[] bytes)
        {
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
