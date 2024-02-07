using Microsoft.AspNetCore.Mvc;
using Blood_Bank.Core.Entities;
using Microsoft.Extensions.Options;
using Blood_Bank.Service;
using Blood_Bank.Core.Services;
using Blood_Bank.Models;
using AutoMapper;
using Blood_Bank.Core.DTOs;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        
        private readonly IDonationsService _donationsService;
        private readonly IMapper _mapper;
        public DonationsController(IDonationsService donationsService, IMapper mapper)
        {
            _mapper = mapper;
            _donationsService = donationsService;
        }
       
        // GET: api/<DonationsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var lst= _donationsService.GetAll();
            var lstDto=new List<DonationsDto>();
            foreach(var item in lst)
            {
                lstDto.Add(_mapper.Map<DonationsDto>(item));
            }
            return Ok(lstDto);
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var donations = _donationsService.Get(id);
            if(donations == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DonationsDto>(donations));
        }

        // POST api/<DonationsController>
        [HttpPost]
        public ActionResult Post([FromBody] DonationsModel dona)
        {
            var donationPost = new Donations { idDonor = dona.idDonor, idSick = dona.idSick, statusDonation = dona.statusDonation };
            _donationsService.Post(donationPost);
            return Ok(_mapper.Map<DonationsDto>(donationPost) );

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Donations dona)
        {
            return Ok(_donationsService.Put(id,dona));
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            
           _donationsService.Delete(id);
            return NoContent();
        }
    }
}
