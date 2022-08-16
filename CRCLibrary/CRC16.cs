using CRCLibrary.Extensions;
using CRCLibrary.Models;

namespace CRCLibrary
{
    //Example
    //https://github.com/sigurn/crc16/blob/master/crc16.go
    public class CRC16
    {
        private const int CheckSumLenght = 4;

        public string GetCheckSumDigi(string input)
        {
            return input.Substring(input.Length - CheckSumLenght);
        }

        public string GetInputWithOutCheckSumDigi(string input)
        {
            return input.Substring(0, input.Length - CheckSumLenght);
        }

        private CRCTable MakeTable(ParamsModel model)
        {
            var table = new CRCTable()
            {
                Params = model,
                Data = new ushort[256]
            };

            for (int i = 0; i < 256; ++i)
            {
                var crc = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    var bit = (crc & 0x8000) != 0;
                    crc <<= 1;
                    if (bit)
                    {
                        crc ^= model.Poly;
                    }
                }

                table.Data[i] = crc;
            }

            return table;
        }

        private ushort Init(CRCTable model)
        {
            return model.Params.Init;
        }

        private ushort Update(ushort crc, byte[] data, CRCTable table)
        {
            foreach (var b in data)
            {
                var d = b;

                if (table.Params.RefIn)
                {
                    d = b.Reverse8();
                }

                crc = (ushort)((crc << 8) ^ table.Data[((crc >> 8) ^ d)]);
            }

            return crc;
        }

        private ushort Complete(ushort crc, CRCTable table)
        {
            if (table.Params.RefOut)
            {
                return (ushort)(crc.Reverse16() ^ table.Params.XorOut);
            }

            return (ushort)(crc ^ table.Params.XorOut);
        }

        public ushort Checksum(string inputAscii, ParamsModel algorithm) => Checksum(inputAscii.AsciiToBytes(), algorithm);

        public ushort Checksum(byte[] data, ParamsModel algorithm)
        {
            var table = MakeTable(algorithm);
            var crc = Init(table);
            crc = Update(crc, data, table);
            return Complete(crc, table);
        }
    }
}