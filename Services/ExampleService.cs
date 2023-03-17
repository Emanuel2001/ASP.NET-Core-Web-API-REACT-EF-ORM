using Microsoft.AspNetCore.Mvc;
using static Web_API.Data.Data;
using Web_API.Models;
using Web_API.DTO;

namespace Web_API.Services
{
    public interface IExampleService
    {
        public Task<Car> Get(int id);
        public Task<List<Car>> GetAll();
        public Task<bool> Create (CarCreateDTO car);
        public Task<bool> Update (Car car);
        public Task<bool> Delete (int id);
    }
    public class ExampleService : IExampleService
    {
        public async Task<Car> Get(int id)
        {
            var car = Cars.FirstOrDefault(x => x.Id == id);

            return car;
        }
        public async Task<List<Car>> GetAll()
        {
            // TU BI IZ BAZE VUKAO VAN ASYNC
            var cars = Cars.ToList();
            return await Task.FromResult(cars);
        }
        public async Task<bool> Create(CarCreateDTO carDto)
        {

            var manufacturer = Manufacturers.FirstOrDefault(x => x.Id == carDto.ManufacturerId);
            if (manufacturer == null)
            {
                return false;
            }

            var newId = Cars.Last().Id + 1;

            var car = new Car()
            {
                Id = newId,
                CarManufacturer = manufacturer,
                IsAutomatic = carDto.IsAutomatic,
                Mileage = carDto.Mileage,
                Model = carDto.Model,
                Motor = carDto.Motor,
                Price = carDto.Price
            };
            Cars.Add(car);
            return true;
        }
        public async Task<bool> Update(Car car)
        {
            var carForUpdate = Cars.FirstOrDefault(x => x.Id == car.Id);
            if(carForUpdate != null)
            {
                carForUpdate = car;
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            var carForDelete = Cars.FirstOrDefault(x => x.Id == id);
            if(carForDelete != null)
            {
                Cars.Remove(carForDelete);
                return true;
            }
            return false;
        }
    }
}
