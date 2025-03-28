namespace UlasimRotaPlanlamaSistemi.Core.Models
{
    public abstract class Yolcu
    {
        public string? Tip { get; set; }
        public abstract double IndirimUygula(double ucret);
    }
}
