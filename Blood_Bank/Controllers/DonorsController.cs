using Microsoft.AspNetCore.Mvc;
using Blood_Bank.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        private readonly DataContext _context;
        public DonorsController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<DonorsController>
        [HttpGet]
        public IEnumerable<Donors> Get()
        {
            return _context.DonorsList;

        }

        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public ActionResult <Donors> Get(int id)
        {
            var dono = _context.DonorsList.Find(d => d.idDonor == id);
            if(dono == null)
            {
                return NotFound();
            }
            return dono;
        }

        // POST api/<DonorsController>
        [HttpPost]
        public void Post(Donors don)
        {
            _context.DonorsList.Add(don);

        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id,Donors don)
        {
            var don2 = _context.DonorsList.Find(d => d.idDonor == id);
            if (don2 == null)
            {
                return NotFound();
            }
            don2.idDonor = don.idDonor;
            don2.fNameDonor = don.fNameDonor;
            don2.lNameDonor = don.lNameDonor;
            don2.statusDonor = don.statusDonor;
            don2.pelephoneDonor = don.pelephoneDonor;
            don2.typeBloodDonor = don.typeBloodDonor;
            return Ok(don2);    
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var don1 = _context.DonorsList.Find(v => v.idDonor == id);
            if (don1 == null)
            {
                return NotFound();
            }
            _context.DonorsList.Remove(don1);
            return Ok();
        }
    }
}
