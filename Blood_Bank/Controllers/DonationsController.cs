using Microsoft.AspNetCore.Mvc;
using Blood_Bank.Entities;
using Microsoft.Extensions.Options;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private static List<Donations> donations = new List<Donations>();

        // GET: api/<DonationsController>
        [HttpGet]
        public IEnumerable<Donations> Get()
        {
            return donations;
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public Donations Get(int id)
        {
            var donat = donations.Find(d => d.idDonation == id);
            return donat;
        }

        // POST api/<DonationsController>
        [HttpPost]
        public void Post(Donations dona)
        {
            donations.Add(dona);

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Donations dona)
        {
            var dona2 = donations.Find(d => d.idDonation == id);
            dona2.idDonation = dona.idDonation;
            dona2.idDonor = dona.idDonor; ;
            dona2.idSick = dona.idSick;
            dona2.statusDonation = dona.statusDonation;
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dona1 = donations.Find(v => v.idDonation == id);
            donations.Remove(dona1);
        }
    }
}
