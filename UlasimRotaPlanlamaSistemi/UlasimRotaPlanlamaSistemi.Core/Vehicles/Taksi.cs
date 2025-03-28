namespace UlasimRotaPlanlamaSistemi.Core.Vehicles
{
    public class Taksi : Arac
    {
        private double openingFee;
        private double costPerKm;
        public Taksi(double openingFee, double costPerKm)
        {
            this.openingFee = openingFee;
            this.costPerKm = costPerKm;
        }
        public override double HesaplaUcret(double mesafe)
        {
            return openingFee + (mesafe * costPerKm);
        }
        public override int HesaplaSure(int sure)
        {
            return sure;
        }
    }
}
