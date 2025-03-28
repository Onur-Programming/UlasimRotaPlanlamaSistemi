namespace UlasimRotaPlanlamaSistemi.Core.Payments
{
    public class Kentkart : Payment
    {
        public double Bakiye { get; set; }
        public Kentkart(double bakiye)
        {
            Bakiye = bakiye;
        }
        public override bool OdemeYap(double miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                return true;
            }
            return false;
        }
    }
}
