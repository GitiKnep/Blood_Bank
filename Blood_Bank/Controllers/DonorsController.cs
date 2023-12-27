using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Services;
using Blood_Bank.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        private readonly IDonorsService _donorsService;
        public DonorsController(IDonorsService donorsService)
        {
            _donorsService = donorsService;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_donorsService.GetAll());
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dono=_donorsService.Get(id);
            if(dono == null)
            {
                return NotFound();
            }
            return Ok(dono);
        }

        // POST api/<DonationsController>
        [HttpPost]
        public ActionResult Post([FromBody] Donors don)
        {
            return Ok( _donorsService.Post(don));

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Donors don)
        {
            return Ok( _donorsService.Put(id, don));
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            _donorsService.Delete(id);
            return NoContent();
        }
    }
}
