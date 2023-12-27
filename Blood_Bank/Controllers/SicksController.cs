using Microsoft.AspNetCore.Mvc;
using System;
using Blood_Bank.Core.Entities;
using System.Threading.Tasks;
using Blood_Bank.Service;
using Blood_Bank.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicksController : ControllerBase
    {

        private readonly ISicksService _sicksService;
        public SicksController(ISicksService sicksService)
        {
            _sicksService = sicksService;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_sicksService.GetAll());
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sic1= _sicksService.Get(id);
            if(sic1==null)
            {
                return NotFound();
            }
            return Ok(sic1);
        }

        // POST api/<DonationsController>
        [HttpPost]
        public ActionResult Post([FromBody] Sicks sic)
        {
            return Ok(_sicksService.Post(sic));

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Sicks sic)
        {
            return Ok( _sicksService.Put(id, sic));
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            _sicksService.Delete(id);
            return NoContent();
        }
    }
    }

