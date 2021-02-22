using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using greg_control.Models;
using greg_control.db;
using greg_control.Services;
namespace greg_control.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController: ControllerBase
    {
        private readonly CarsService _CS;
        public CarsController(CarsService cs)
        {
            _CS = cs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAll()
        {
            try
            {
                return Ok(_CS.Get());
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetOne(string id)
        {
            try
            {
                return Ok(_CS.GetOne(id));
            }
             catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car newCar)
        {
            try
            {
                return Ok(_CS.Create(newCar));
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Car> Edit(string id, [FromBody] Car bodyCar)
        {
            try
            {
                return Ok(_CS.Edit(id, bodyCar));
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(string id)
        {
            try
            {
                return Ok(_CS.Delete(id));
            }
             catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}