using Web_API.Models;
using Web_API.Services;

namespace Web_API.Data
{
    public static class Data
    {
        public static List<Manufacturer> Manufacturers = new List<Manufacturer>()
        {
                new Manufacturer{Id = 0,Name = "BMW"},
                new Manufacturer{Id = 1,Name = "Volvo" }
        };
        public static List<Car> Cars = new List<Car>()
        {
            new Car{Id = 1, CarManufacturer = ManufacturerService.GetManufacturer(0)},
            new Car{Id = 2, CarManufacturer = ManufacturerService.GetManufacturer(1)}
        };
    }
}
