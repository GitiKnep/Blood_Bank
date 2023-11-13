using Microsoft.AspNetCore.Mvc;
using Blood_Bank.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class SicksController : ControllerBase
    {
        private readonly DataContext _context;
        public SicksController(DataContext context)
        {
            _context = context;
        }


        // GET: api/<SicksController>
        [HttpGet]
        public IEnumerable<Sicks> Get()
        {

            return _context.SicksList;
        }

        // GET api/<SicksController>/5
        [HttpGet("{id}")]
        public ActionResult <Sicks> Get(int id)
        {
            var sic3 = _context.SicksList.Find(s => s.idSick == id);
            if (sic3 == null)
            {
                return NotFound();
            }
            return sic3;
        }

        // POST api/<SicksController>
        [HttpPost]
        public void Post(Sicks sic)
        {
            _context.SicksList.Add(sic);

        }

        // PUT api/<SicksController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Sicks sic)
        {
            var sic2 = _context.SicksList.Find(s => s.idSick == id);
            if (sic2 == null)
            {
                NotFound();
            }
            sic2.idSick = sic.idSick;
            sic2.fNameSick = sic.fNameSick;
            sic2.lNameSick = sic.lNameSick;
            sic2.typeBloodSick = sic.typeBloodSick;
            sic2.pelephoneSick = sic.pelephoneSick;
            sic2.statusSick = sic.statusSick;
            return Ok(sic2);
        }

        // DELETE api/<SicksController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var sic1 = _context.SicksList.Find(s => s.idSick == id);
            if (sic1 == null)
            {
                return NotFound();
            }
            _context.SicksList.Remove(sic1);
            return Ok();
        }
    }
}
