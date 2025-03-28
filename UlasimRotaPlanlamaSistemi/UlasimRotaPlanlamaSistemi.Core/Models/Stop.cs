using System.Collections.Generic;

namespace UlasimRotaPlanlamaSistemi.Core.Models
{
    public class Stop
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? type { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public bool sonDurak { get; set; }
        public List<NextStop>? nextStops { get; set; }
        public Transfer? transfer { get; set; }
    }
}
