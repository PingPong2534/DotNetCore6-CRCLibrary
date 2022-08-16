# DotNetCore6-CRCLibrary
Check Sum by using CRC Algorithm

**now support only CRC-16 include Algorithm**
1. CCITT-FALSE        
2. ARC                
3. AUG-CCITT          
4. BUYPASS            
5. CDMA2000           
6. DDS-110            
7. DECT-R             
8. DECT-X             
9. DNP                
10. EN-13757           
11. GENIBUS            
12. MAXIM              
13. MCRF4XX            
14. RIELLO             
15. T10-DIF            
16. TELEDISK           
17. TMS37157           
18. USB                
19. CRC-A              
20. KERMIT             
21. MODBUS             
22. X-25               
23. XMODEM             

# Referents
I convert go language to C# by using example from this site https://github.com/sigurn/crc16/blob/master/crc16.go

We can check result from this site https://crccalc.com/?crc=123456789&method=crc16&datatype=ascii&outtype=0

# Example
## C# Code
```
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
```

## Out Put
```
input data => "123456789"

CCITT-FALSE         = 0x29B1
ARC                 = 0xBB3D
AUG-CCITT           = 0xE5CC
BUYPASS             = 0xFEE8
CDMA2000            = 0x4C06
DDS-110             = 0x9ECF
DECT-R              = 0x007E
DECT-X              = 0x007F
DNP                 = 0xEA82
EN-13757            = 0xC2B7
GENIBUS             = 0xD64E
MAXIM               = 0x44C2
MCRF4XX             = 0x6F91
RIELLO              = 0x63D0
T10-DIF             = 0xD0DB
TELEDISK            = 0x0FB3
TMS37157            = 0x26B1
USB                 = 0xB4C8
CRC-A               = 0xBF05
KERMIT              = 0x2189
MODBUS              = 0x4B37
X-25                = 0x906E
XMODEM              = 0x31C3
```
