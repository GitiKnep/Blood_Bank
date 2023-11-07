using Blood_Bank.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private static List<Donations> donations = new List<Donations>();
        [HttpGet]
        public IEnumerable<Donations> Get()
        {
            return donations;
        }

        
        
        [HttpPost]
        public void Post(Donations dona)
        {
            donations.Add(dona);
        }

      
        [HttpPut("{id}")]
        public void Put(int id, Donations dona)
        {
            var dona2 = donations.Find(d => d.idDonation == id);
            dona2.idDonation=dona.idDonation;
            dona2.idDonor=dona.idDonor; ;
            dona2.idVolunteer=dona.idVolunteer;
            dona2.statusDonation=dona.statusDonation;
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
