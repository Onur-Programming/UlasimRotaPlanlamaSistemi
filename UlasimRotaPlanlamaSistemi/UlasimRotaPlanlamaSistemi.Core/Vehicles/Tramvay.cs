namespace UlasimRotaPlanlamaSistemi.Core.Vehicles
{
    public class Tramvay : Arac
    {
        public override double HesaplaUcret(double mesafe)
        {
            return mesafe * 0.8; // Örnek hesaplama
        }
        public override int HesaplaSure(int sure)
        {
            return sure;
        }
    }
}
