// Test site https://crccalc.com/?crc=123456789&method=crc16&datatype=ascii&outtype=0
using CRCLibrary;
using CRCLibrary.Constants;

var input = "123456789";

Action<string, ushort> Write = (name, result) => Console.WriteLine($"{name.Replace("_", "-").PadRight(20)}= 0x{result.ToString("x4").ToUpper()}");

var crc16 = new CRC16();

var parramName = nameof(CRC16AlgorithmParams.CCITT_FALSE);
var parrams = CRC16AlgorithmParams.CCITT_FALSE;
var result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.ARC);
parrams = CRC16AlgorithmParams.ARC;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.AUG_CCITT);
parrams = CRC16AlgorithmParams.AUG_CCITT;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.BUYPASS);
parrams = CRC16AlgorithmParams.BUYPASS;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.CDMA2000);
parrams = CRC16AlgorithmParams.CDMA2000;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.DDS_110);
parrams = CRC16AlgorithmParams.DDS_110;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.DECT_R);
parrams = CRC16AlgorithmParams.DECT_R;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.DECT_X);
parrams = CRC16AlgorithmParams.DECT_X;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.DNP);
parrams = CRC16AlgorithmParams.DNP;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.EN_13757);
parrams = CRC16AlgorithmParams.EN_13757;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.GENIBUS);
parrams = CRC16AlgorithmParams.GENIBUS;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.MAXIM);
parrams = CRC16AlgorithmParams.MAXIM;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.MCRF4XX);
parrams = CRC16AlgorithmParams.MCRF4XX;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.RIELLO);
parrams = CRC16AlgorithmParams.RIELLO;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.T10_DIF);
parrams = CRC16AlgorithmParams.T10_DIF;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.TELEDISK);
parrams = CRC16AlgorithmParams.TELEDISK;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.TMS37157);
parrams = CRC16AlgorithmParams.TMS37157;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.USB);
parrams = CRC16AlgorithmParams.USB;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.CRC_A);
parrams = CRC16AlgorithmParams.CRC_A;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.KERMIT);
parrams = CRC16AlgorithmParams.KERMIT;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.MODBUS);
parrams = CRC16AlgorithmParams.MODBUS;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.X_25);
parrams = CRC16AlgorithmParams.X_25;
result = crc16.Checksum(input, parrams);
Write(parramName, result);

parramName = nameof(CRC16AlgorithmParams.XMODEM);
parrams = CRC16AlgorithmParams.XMODEM;
result = crc16.Checksum(input, parrams);
Write(parramName, result);