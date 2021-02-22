using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using greg_control.Models;
using greg_control.db;
using greg_control.Services;

namespace greg_control.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _JS;
        public JobsController(JobsService js)
        {
            _JS = js;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Job>> GetAll()
        {
            try
            {
                return Ok(_JS.Get());
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Job> GetOne(string id)
        {
            try
            {
                return Ok(_JS.GetOne(id));
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        [HttpPost]
        public ActionResult<IEnumerable<Job>> Create([FromBody] Job jobBody)
        {
            try
            {
                return Ok(_JS.Create(jobBody));
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<Job> Edit(string id, [FromBody] Job bodyJob)
         {
            try
            {
                return Ok(_JS.Edit(id, bodyJob));
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<Job> Delete(string id)
        {
            try
            {
                return Ok(_JS.Delete(id));
            }
            catch(System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}