using Web_API.Models;
using Web_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id) 
        {
            if (id < 0) 
            {
                return BadRequest();
            }
            return CarService.Get(id);
        }
        [HttpGet]
        public ActionResult<List<Car>> GetAll() => CarService.GetAll();
        [HttpPost]
        public IActionResult Create(Car car) 
        { 
            if(car == null) 
            { 
                return BadRequest(); 
            }
            CarService.Create(car);
            return CreatedAtAction(nameof(Get),car);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,Car car) 
        {
            if (id < 0 || car == null )
            {
                return BadRequest();
            }
            CarService.Update(id,car);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            if (id < 0)
            {
                return BadRequest();
            }
            CarService.Delete(id);
            return Ok();
        }
    }
}
