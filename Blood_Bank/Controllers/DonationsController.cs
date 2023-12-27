using Microsoft.AspNetCore.Mvc;
using Blood_Bank.Core.Entities;
using Microsoft.Extensions.Options;
using Blood_Bank.Service;
using Blood_Bank.Core.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private readonly IDonationsService _donationsService;
        public DonationsController(IDonationsService donationsService)
        {
            _donationsService = donationsService;
        }
       
        // GET: api/<DonationsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_donationsService.GetAll());
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var donations = _donationsService.Get(id);
            if(donations == null)
            {
                return NotFound();
            }
            return Ok(donations);
        }

        // POST api/<DonationsController>
        [HttpPost]
        public ActionResult Post([FromBody] Donations dona)
        {
            return Ok( _donationsService.Post(dona));

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Donations dona)
        {
            return Ok(_donationsService.Put(id,dona));
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            
           _donationsService.Delete(id);
            return NoContent();
        }
    }
}
