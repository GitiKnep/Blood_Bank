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
        private readonly DataContext _context;
        public DonationsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public IEnumerable<Donations> Get()
        {
            return _context.DonationsList;
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public ActionResult <Donations> Get(int id)
        {
            var donat = _context.DonationsList.Find(d => d.idDonation == id);
            if(donat == null)
            {
                return NotFound();
            }
            return donat;

        }

        // POST api/<DonationsController>
        [HttpPost]
        public void Post(Donations dona)
        {
            _context.DonationsList.Add(dona);

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Donations dona)
        {
            var dona2 = _context.DonationsList.Find(d => d.idDonation == id);
            if(dona2 == null)
            {
                return NotFound();
            }
            dona2.idDonation = dona.idDonation;
            dona2.idDonor = dona.idDonor; ;
            dona2.idSick = dona.idSick;
            dona2.statusDonation = dona.statusDonation;
            return Ok(dona2);
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var dona1 = _context.DonationsList.Find(v => v.idDonation == id);
            if(dona1 == null)
            {
                return NotFound();
            }
            _context.DonationsList.Remove(dona1);
            return Ok(dona1);   
        }
    }
}
