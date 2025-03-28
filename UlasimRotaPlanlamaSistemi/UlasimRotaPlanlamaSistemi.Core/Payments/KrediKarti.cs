namespace UlasimRotaPlanlamaSistemi.Core.Payments
{
    public class KrediKarti : Payment
    {
        public double Limit { get; set; }
        public KrediKarti(double limit)
        {
            Limit = limit;
        }
        public override bool OdemeYap(double miktar)
        {
            if (Limit >= miktar)
            {
                Limit -= miktar;
                return true;
            }
            return false;
        }
    }
}
