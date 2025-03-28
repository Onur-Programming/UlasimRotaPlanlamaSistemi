namespace UlasimRotaPlanlamaSistemi.Core.Models
{
    public class Route
    {
        public List<Stop> Stops { get; set; } = new List<Stop>();
        public double TotalDistance { get; set; }
        public int TotalTime { get; set; }
        public double TotalCost { get; set; }
    }
}
