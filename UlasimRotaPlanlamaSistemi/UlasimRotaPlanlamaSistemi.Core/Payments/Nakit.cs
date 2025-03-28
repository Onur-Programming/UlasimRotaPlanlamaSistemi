namespace UlasimRotaPlanlamaSistemi.Core.Payments
{
    public class Nakit : Payment
    {
        public double NakitMiktar { get; set; }
        public Nakit(double nakitMiktar)
        {
            NakitMiktar = nakitMiktar;
        }
        public override bool OdemeYap(double miktar)
        {
            if (NakitMiktar >= miktar)
            {
                NakitMiktar -= miktar;
                return true;
            }
            return false;
        }
    }
}
