using Web_API.Models;

namespace Web_API.Services
{
    public class ManufacturerService
    {
        public static List<Manufacturer> CarManufacturers { get; set; }
        static ManufacturerService() 
        {
            CarManufacturers = new List<Manufacturer> 
            { 
                new Manufacturer{Id = 0,Name = "BMW"},
                new Manufacturer{Id = 1,Name = "Volvo" }
            };
        }
        public static Manufacturer GetManufacturer(int id)
        {
            var index = CarManufacturers.FindIndex(m => m.Id == id);
            return CarManufacturers[index];
        }
        public static void AddManufacturedCar(Car car)
        {
            var index = CarManufacturers.FindIndex(m => m.Id == car.CarManufacturer.Id);
            if(CarManufacturers[index].ManufacturedCars == null) 
            {
                CarManufacturers[index].ManufacturedCars = new List<Car> { car };
            }
            CarManufacturers[index].ManufacturedCars.Add(car);
        }
        public static bool CheckCarManufacturer(int id) 
        {
            if(CarManufacturers.FirstOrDefault(m => m.Id == id) == null) 
            {
                return true;
            }
            return false;
        }
        public static void UpdateManufacturedCar(int id,Car newCar)
        {
            Car oldCar = CarService.Get(id);
            var index = CarManufacturers.FindIndex(m => m.Id == oldCar.CarManufacturer.Id);
            var carIndex = CarManufacturers[index].ManufacturedCars.FindIndex(c => c.Id == oldCar.Id);
            CarManufacturers[index].ManufacturedCars[carIndex] = newCar;
        }
        public static void DeleteManufacturedCar(int id)
        {
            Car car = CarService.Get(id);

            var index = CarManufacturers.FindIndex(m => m.Id == car.CarManufacturer.Id);
            Car tempCar = CarManufacturers[index].ManufacturedCars.FirstOrDefault(c => c.Id == car.Id);
            CarManufacturers[index].ManufacturedCars.Remove(tempCar);
        }

    }
}
