using System;
using UlasimRotaPlanlamaSistemi.Core.Models;

namespace UlasimRotaPlanlamaSistemi.Core.Services
{
    public class RotaHesaplayici
    {
        private City city;
        public RotaHesaplayici(City city)
        {
            this.city = city;
        }
        
        public double MesafeHesapla(double lat1, double lon1, double lat2, double lon2)
        {
            double R = 6371; // Dünya yarıçapı (km)
            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }
        
        private double ToRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }
        
        public Stop? EnYakinDuragiBul(double userLat, double userLon)
        {
            Stop? enYakin = null;
            double minMesafe = double.MaxValue;
            foreach (var durak in city.duraklar ?? new List<Stop>())
            {
                double mesafe = MesafeHesapla(userLat, userLon, durak.lat, durak.lon);
                if (mesafe < minMesafe)
                {
                    minMesafe = mesafe;
                    enYakin = durak;
                }
            }
            return enYakin;
        }
    }
}
