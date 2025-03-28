namespace UlasimRotaPlanlamaSistemi.Core.Models
{
    public class GenelYolcu : Yolcu
    {
        public GenelYolcu()
        {
            Tip = "Genel";
        }
        public override double IndirimUygula(double ucret)
        {
            return ucret;
        }
    }
}
