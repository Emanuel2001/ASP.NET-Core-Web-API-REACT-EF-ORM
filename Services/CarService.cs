using Web_API.Models;

namespace Web_API.Services
{
    public class CarService
    {
        static List<Car> Cars { get; }
        static int idIterator = 3;
        static CarService() 
        {
            Cars = new List<Car>
            {
            new Car{Id = 1},
            new Car{Id = 2}
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
            Cars.Add(car);
        }
        //Put 
        public static void Update(int id, Car car) 
        {
            int index = Cars.FindIndex(c => c.Id == id);
            Cars[index] = car;
        }
        //Delete
        public static void Delete(int id)
        {
            int index = Cars.FindIndex(c => c.Id == id);
            Cars.Remove(Cars[index]);
        }
    }
}
