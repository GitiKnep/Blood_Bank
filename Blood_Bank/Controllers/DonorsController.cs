using Blood_Bank.Entities;
using Microsoft.AspNetCore.Mvc;


namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        private static List<Donors> donors = new List<Donors>();
       
        [HttpGet]
        public IEnumerable<Donors> Get()
        {
            return donors;
        }
        [HttpPut("{id}")]
        public Donors Get(int id)
        {
            var dono = donors.Find(d => d.idDonor == id);
            return dono;
        }

        [HttpPost]
        public void Post(Donors don)
        {
            donors.Add(don);    
        }

        [HttpPut("{id}")]
        public void Put(int id, Donors don)
        {
            var don2 = donors.Find(d => d.idDonor == id);
            don2.idDonor = don.idDonor;
            don2.fNameDonor = don.fNameDonor;
            don2.lNameDonor = don.lNameDonor;
            don2.statusDonor = don.statusDonor;
            don2.pelephoneDonor = don.pelephoneDonor;
            don2.typeBloodDonor = don.typeBloodDonor;
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var don1 = donors.Find(v => v.idDonor == id);
           donors.Remove(don1);
        }
    }
}
