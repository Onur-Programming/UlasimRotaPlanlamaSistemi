using System.Collections.Generic;

namespace UlasimRotaPlanlamaSistemi.Core.Models
{
    public class City
    {
        public string? city { get; set; }
        public Taxi? taxi { get; set; }
        public List<Stop>? duraklar { get; set; }
    }
}
