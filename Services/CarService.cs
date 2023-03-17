using Web_API.Models;

namespace Web_API.Services
{
    public class CarService
    {
        static List<Car> Cars { get; set; }
        static int idIterator = 3;
        static CarService() 
        {
            Cars = new List<Car>
            {
            //new Car{Id = 1, CarManufacturer = ManufacturerService.GetManufacturer(0)},
            //new Car{Id = 2, CarManufacturer = ManufacturerService.GetManufacturer(1)}
            };
        }
        //GetById
        public static Car? Get(int id) 
        {
            return Cars.FirstOrDefault(c => c.Id == id);
        }
        //Get
        public static List<Car> GetAll() => Cars;
        //Post
        public static void Create(Car car) 
        { 
            car.Id = idIterator++;
            ManufacturerService.AddManufacturedCar(car);
            Cars.Add(car);
        }
        //Put 
        public static void Update(int id, Car newCar) 
        {
            int index = Cars.FindIndex(c => c.Id == id);
            Cars[index] = newCar;
        }
        //Delete
        public static void Delete(int id)
        {
            int index = Cars.FindIndex(c => c.Id == id);
            Cars.Remove(Cars[index]);
        }
    }
}
