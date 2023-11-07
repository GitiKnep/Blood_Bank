using Microsoft.AspNetCore.Mvc;
using Blood_Bank.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicksController : ControllerBase
    {
        private static List<Sicks> sicks = new List<Sicks>();

        // GET: api/<SicksController>
        [HttpGet]
        public IEnumerable<Sicks> Get()
        {
            return sicks;
        }

        // GET api/<SicksController>/5
        [HttpGet("{id}")]
        public Sicks Get(int id)
        {
            var sic3 = sicks.Find(s => s.idSick == id);
            return sic3;
        }

        // POST api/<SicksController>
        [HttpPost]
        public void Post(Sicks sic)
        {
            sicks.Add(sic);

        }

        // PUT api/<SicksController>/5
        [HttpPut("{id}")]
        public void Put(int id, Sicks sic)
        {
            var sic2 = sicks.Find(s => s.idSick == id);
            sic2.idSick = sic.idSick;
            sic2.fNameSick = sic.fNameSick;
            sic2.lNameSick = sic.lNameSick;
            sic2.typeBloodSick = sic.typeBloodSick;
            sic2.pelephoneSick = sic.pelephoneSick;
            sic2.statusSick = sic.statusSick;
        }

        // DELETE api/<SicksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var sic1 = sicks.Find(s => s.idSick == id);
            sicks.Remove(sic1);
        }
    }
}
