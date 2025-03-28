namespace UlasimRotaPlanlamaSistemi.Core.Models
{
    public class Ogrenci : Yolcu
    {
        public Ogrenci()
        {
            Tip = "Ogrenci";
        }
        public override double IndirimUygula(double ucret)
        {
            return ucret * 0.5;
        }
    }
}
