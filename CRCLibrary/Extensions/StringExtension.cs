using System.Text;

namespace CRCLibrary.Extensions
{
    internal static class StringExtension
    {
        public static byte[] AsciiToBytes(this string ascii)
        {
            return Encoding.ASCII.GetBytes(ascii);
        }

        public static byte[] UnicodeToBytes(this string ascii)
        {
            return Encoding.Unicode.GetBytes(ascii);
        }

        public static byte[] Utf8ToBytes(this string ascii)
        {
            return Encoding.UTF8.GetBytes(ascii);
        }

        public static byte[] Utf32ToBytes(this string ascii)
        {
            return Encoding.UTF32.GetBytes(ascii);
        }

        public static byte[] Latin1ToBytes(this string ascii)
        {
            return Encoding.Latin1.GetBytes(ascii);
        }
    }
}