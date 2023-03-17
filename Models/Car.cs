using System.Text.Json.Serialization;

namespace Web_API.Models
{
    public class Car
    {
        public Car() { }
        public Car(int id, Manufacturer manufacturer) 
        { 
            Id = id;
            //Needs optimization
            CarManufacturer = manufacturer;
        }
        public int Id { get; set; }
        public Manufacturer CarManufacturer { get; set; }
        public string? Model { get; set; }
        public double? Mileage { get; set; }
        public double? Price { get; set; }
        public string? Motor { get; set; }
        public bool? IsAutomatic { get; set; }  
    }
}
