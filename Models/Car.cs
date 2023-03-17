namespace Web_API.Models
{
    public class Car
    {
        public Car(){}
        public Car(int id, string model, double mileage, double price, string motor, bool isAutomatic)
        {
            Id = id;
            Model = model;
            Mileage = mileage;
            Price = price;
            Motor = motor;
            IsAutomatic = isAutomatic;
        }
        public int Id { get; set; }
        public string? Model { get; set; }
        public double? Mileage { get; set; }
        public double? Price { get; set; }
        public string? Motor { get; set; }
        public bool? IsAutomatic { get; set; }
    }
}
