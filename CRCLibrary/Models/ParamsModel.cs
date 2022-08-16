namespace CRCLibrary.Models
{
    public class ParamsModel
    {
        public ushort Check { get; set; }
        public ushort Poly { get; set; }
        public ushort Init { get; set; }
        public bool RefIn { get; set; }
        public bool RefOut { get; set; }
        public ushort XorOut { get; set; }

        public ParamsModel(ushort Check, ushort Poly, ushort Init, bool RefIn, bool RefOut, ushort XorOut)
        {
            this.Check = Check;
            this.Poly = Poly;
            this.Init = Init;
            this.RefIn = RefIn;
            this.RefOut = RefOut;
            this.XorOut = XorOut;
        }
    }
}