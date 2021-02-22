using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using greg_control.Models;
using greg_control.db;
using greg_control.Services;

namespace greg_control.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _HS;
        public HousesController(HousesService hs)
        {
            _HS = hs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<House>> GetAll()
        {
            try
            {
                return Ok(_HS.Get());
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
                return Ok(_HS.GetOne(id));
            }
             catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                return Ok(_HS.Create(newHouse));
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<House> Edit(string id, [FromBody] House bodyHouse)
        {
            try
            {
                return Ok(_HS.Edit(id, bodyHouse));
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
                return Ok(_HS.Delete(id));
            }
             catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}