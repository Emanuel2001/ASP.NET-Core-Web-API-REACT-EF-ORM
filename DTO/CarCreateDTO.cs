namespace Web_API.DTO
{
    public class CarCreateDTO
    {
        public int ManufacturerId { get; set; }
        public string? Model { get; set; }
        public double? Mileage { get; set; }
        public double? Price { get; set; }
        public string? Motor { get; set; }
        public bool? IsAutomatic { get; set; }
    }
}
