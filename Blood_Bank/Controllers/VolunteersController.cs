using Blood_Bank.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteersController : ControllerBase
    {
        private static List<Volunteers> volunteers = new List<Volunteers>();
        [HttpGet]
        public IEnumerable<Volunteers> Get()
        {
            return volunteers;
        }
        [HttpPut("{id}")]
        public Volunteers Get(int id)
        {
            var volu = volunteers.Find(v => v.idVolunteer == id);
            return volu;
        }
        [HttpPost]
        public void Post(Volunteers vol)
        {
            volunteers.Add(vol);
        }

        
        [HttpPut("{id}")]
        public void Put(int id, Volunteers vol)
        {
            var vol2 = volunteers.Find(v => v.idVolunteer == id);
            vol2.idVolunteer= vol.idVolunteer;
            vol2.fNameVolunteer = vol.fNameVolunteer;
            vol2.lNameVolunteer=vol.lNameVolunteer;
            vol2.statusVolunteer = vol.statusVolunteer;
            vol2.pelephoneVolunteer = vol.pelephoneVolunteer;
            vol2.typeBloodVolunteer = vol.typeBloodVolunteer;
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var vol1=volunteers.Find(v=>v.idVolunteer==id); 
            volunteers.Remove(vol1);
        }
    }
}
