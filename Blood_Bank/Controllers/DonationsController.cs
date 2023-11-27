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
        public IEnumerable<Donations> GetAll()
        {
            return (IEnumerable<Donations>)_donationsService.GetAll();
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public ActionResult < Donations> Get(int id)
        {
            return Ok(_donationsService.Get(id));
        }

        // POST api/<DonationsController>
        [HttpPost]
        public void Post(Donations dona)
        {
            _donationsService.Post(dona);

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Donations dona)
        {
           _donationsService.Put(id,dona);
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
           _donationsService.Delete(id);

        }
    }
}
