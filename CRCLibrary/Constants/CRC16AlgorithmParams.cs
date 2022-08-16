using CRCLibrary.Models;

namespace CRCLibrary.Constants
{
    public sealed class CRC16AlgorithmParams
    {
        public static ParamsModel CCITT_FALSE => new ParamsModel(0x29B1, 0x1021, 0xFFFF, false, false, 0x0000);
        public static ParamsModel ARC => new ParamsModel(0xBB3D, 0x8005, 0x0000, true, true, 0x0000);
        public static ParamsModel AUG_CCITT => new ParamsModel(0xE5CC, 0x1021, 0x1D0F, false, false, 0x0000);
        public static ParamsModel BUYPASS => new ParamsModel(0xFEE8, 0x8005, 0x0000, false, false, 0x0000);
        public static ParamsModel CDMA2000 => new ParamsModel(0x4C06, 0xC867, 0xFFFF, false, false, 0x0000);
        public static ParamsModel DDS_110 => new ParamsModel(0x9ECF, 0x8005, 0x800D, false, false, 0x0000);
        public static ParamsModel DECT_R => new ParamsModel(0x007E, 0x0589, 0x0000, false, false, 0x0001);
        public static ParamsModel DECT_X => new ParamsModel(0x007F, 0x0589, 0x0000, false, false, 0x0000);
        public static ParamsModel DNP => new ParamsModel(0xEA82, 0x3D65, 0x0000, true, true, 0xFFFF);
        public static ParamsModel EN_13757 => new ParamsModel(0xC2B7, 0x3D65, 0x0000, false, false, 0xFFFF);
        public static ParamsModel GENIBUS => new ParamsModel(0xD64E, 0x1021, 0xFFFF, false, false, 0xFFFF);
        public static ParamsModel MAXIM => new ParamsModel(0x44C2, 0x8005, 0x0000, true, true, 0xFFFF);
        public static ParamsModel MCRF4XX => new ParamsModel(0x6F91, 0x1021, 0xFFFF, true, true, 0x0000);
        public static ParamsModel RIELLO => new ParamsModel(0x63D0, 0x1021, 0xB2AA, true, true, 0x0000);
        public static ParamsModel T10_DIF => new ParamsModel(0xD0DB, 0x8BB7, 0x0000, false, false, 0x0000);
        public static ParamsModel TELEDISK => new ParamsModel(0x0FB3, 0xA097, 0x0000, false, false, 0x0000);
        public static ParamsModel TMS37157 => new ParamsModel(0x26B1, 0x1021, 0x89EC, true, true, 0x0000);
        public static ParamsModel USB => new ParamsModel(0xB4C8, 0x8005, 0xFFFF, true, true, 0xFFFF);
        public static ParamsModel CRC_A => new ParamsModel(0xBF05, 0x1021, 0xC6C6, true, true, 0x0000);
        public static ParamsModel KERMIT => new ParamsModel(0x2189, 0x1021, 0x0000, true, true, 0x0000);
        public static ParamsModel MODBUS => new ParamsModel(0x4B37, 0x8005, 0xFFFF, true, true, 0x0000);
        public static ParamsModel X_25 => new ParamsModel(0x906E, 0x1021, 0xFFFF, true, true, 0xFFFF);
        public static ParamsModel XMODEM => new ParamsModel(0x31C3, 0x1021, 0x0000, false, false, 0x0000);
    }
}