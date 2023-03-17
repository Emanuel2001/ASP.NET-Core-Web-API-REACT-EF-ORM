using System.Text.Json.Serialization;

namespace Web_API.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public List<Car>? ManufacturedCars { get; set; } 
    }
}
