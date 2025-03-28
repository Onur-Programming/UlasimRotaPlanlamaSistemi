namespace UlasimRotaPlanlamaSistemi.Core.Models
{
    public class Yasli : Yolcu
    {
        public Yasli()
        {
            Tip = "65+";
        }
        public override double IndirimUygula(double ucret)
        {
            return ucret * 0.8;
        }
    }
}
