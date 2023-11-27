using Microsoft.AspNetCore.Mvc;
using System;
using Blood_Bank.Core.Entities;
using System.Threading.Tasks;
using Blood_Bank.Service;
using Blood_Bank.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicksController : ControllerBase
    {

        private readonly ISicksService _sicksService;
        public SicksController(ISicksService sicksService)
        {
            _sicksService = sicksService;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public IEnumerable<Sicks> Get()
        {
            return (IEnumerable<Sicks>)_sicksService.Get();
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public ActionResult<Sicks> Get(int id)
        {
            return Ok(_sicksService.Get(id));
        }

        // POST api/<DonationsController>
        [HttpPost]
        public void Post(Sicks sic)
        {
            _sicksService.Post(sic);

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Sicks sic)
        {
           _sicksService.Put(id, sic);
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _sicksService.Delete(id);
            
        }
    }
    }
}
