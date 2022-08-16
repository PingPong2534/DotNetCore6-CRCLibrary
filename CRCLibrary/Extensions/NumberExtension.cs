namespace CRCLibrary.Extensions
{
    internal static class NumberExtension
    {
        public static byte Reverse8(this byte inByte)
        {
            byte result = 0x00;

            for (byte mask = 0x80; Convert.ToInt32(mask) > 0; mask >>= 1)
            {
                // shift right current result
                result = (byte)(result >> 1);

                // tempbyte = 1 if there is a 1 in the current position
                var tempbyte = (byte)(inByte & mask);
                if (tempbyte != 0x00)
                {
                    // Insert a 1 in the left
                    result = (byte)(result | 0x80);
                }
            }

            return (result);
        }

        public static ushort Reverse16(this ushort inByte)
        {
            ushort result = 0x0000;

            for (ushort mask = 0x8000; Convert.ToInt32(mask) > 0; mask >>= 1)
            {
                // shift right current result
                result = (ushort)(result >> 1);

                // tempbyte = 1 if there is a 1 in the current position
                var tempbyte = (ushort)(inByte & mask);
                if (tempbyte != 0x0000)
                {
                    // Insert a 1 in the left
                    result = (ushort)(result | 0x8000);
                }
            }

            return (result);
        }
    }
}