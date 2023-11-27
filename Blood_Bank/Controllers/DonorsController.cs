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
        public IEnumerable<Donors> GetAll()
        {
            return (IEnumerable<Donors>)_donorsService.GetAll();
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public ActionResult<Donors> Get(int id)
        {
            return Ok(_donorsService.Get(id));
        }

        // POST api/<DonationsController>
        [HttpPost]
        public void Post(Donors don)
        {
            _donorsService.Post(don);

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Donors don)
        {
            _donorsService.Put(id, don);
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _donorsService.Delete(id);

        }
    }
}
