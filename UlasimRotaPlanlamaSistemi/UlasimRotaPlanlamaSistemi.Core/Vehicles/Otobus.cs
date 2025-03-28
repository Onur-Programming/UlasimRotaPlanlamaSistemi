namespace UlasimRotaPlanlamaSistemi.Core.Vehicles
{
    public class Otobus : Arac
    {
        public override double HesaplaUcret(double mesafe)
        {
            return mesafe * 1.0; // Örnek hesaplama
        }
        public override int HesaplaSure(int sure)
        {
            return sure;
        }
    }
}
