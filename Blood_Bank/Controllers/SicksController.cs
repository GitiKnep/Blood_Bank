using Blood_Bank.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicksController : ControllerBase
    {
        private static List<Sicks> sicks = new List<Sicks>();
        [HttpGet]
        public IEnumerable<Sicks> Get()
        {
            return sicks;
        }
        [HttpPut("{id}")]
        public Sicks Get(int id)
        {
            var sic3 = sicks.Find(s => s.idSick == id);
            return sic3;
        }
        [HttpPost]
        public void Post(Sicks sic)
        {
            sicks.Add(sic);
        }

        
        [HttpPut("{id}")]
        public void Put(int id, Sicks sic)
        {
            var sic2 = sicks.Find(s => s.idSick == id);
            sic2.idSick= sic.idSick;
            sic2.fNameSick = sic.fNameSick;
            sic2.lNameSick=sic.lNameSick;
            sic2.typeBloodSick = sic.typeBloodSick;
            sic2.pelephoneSick = sic.pelephoneSick;
            sic2.statusSick = sic.statusSick;
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var sic1=sicks.Find(s => s.idSick==id); 
            sicks.Remove(sic1);
        }
    }
}
