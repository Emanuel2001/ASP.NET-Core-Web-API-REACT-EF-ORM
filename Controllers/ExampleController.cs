using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API.DTO;
using Web_API.Models;
using Web_API.Services;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : Controller
    {
        private readonly IExampleService _exampleService;

        public ExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await _exampleService.Get(id);
                return Ok(result);
            }
            catch
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _exampleService.GetAll();
                return Ok(result);
            }
            catch
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Create(CarCreateDTO car)
        {
            try
            {
                var result = await _exampleService.Create(car);
                if(result)
                    return Ok();
                else
                    return BadRequest();
            }
            catch
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(Car car)
        {
            try
            {
                var result = await _exampleService.Update(car);
                if (result)
                    return Ok();
                else
                    return BadRequest();
            }
            catch
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _exampleService.Delete(id);
                if (result)
                    return Ok();
                else
                    return BadRequest();
            }
            catch
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
