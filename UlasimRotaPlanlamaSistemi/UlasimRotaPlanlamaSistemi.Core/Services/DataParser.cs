using Newtonsoft.Json;
using UlasimRotaPlanlamaSistemi.Core.Models;

namespace UlasimRotaPlanlamaSistemi.Core.Services
{
    public class DataParser
    {
        public static City? ParseCityData(string jsonData)
        {
            return JsonConvert.DeserializeObject<City>(jsonData);
        }
    }
}
