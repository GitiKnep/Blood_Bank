using Microsoft.AspNetCore.Mvc;
using System;
using Blood_Bank.Core.Entities;
using System.Threading.Tasks;
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
    public class SicksController : ControllerBase
    {

        private readonly ISicksService _sicksService;
        private readonly IMapper _mapper;

        public SicksController(ISicksService sicksService, IMapper mapper)
        {
            _mapper = mapper;
            _sicksService = sicksService;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var lst = _sicksService.GetAll();
            var lstDto = new List<SicksDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<SicksDto>(item));
            }
            return Ok(lstDto);
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sic1= _sicksService.Get(id);
            if(sic1==null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<SicksDto>(sic1));
        }

        // POST api/<DonationsController>
        [HttpPost]
        public ActionResult Post([FromBody] SicksModel sic)
        {
            var sickPost=new Sicks {fNameSick=sic.fNameSick,lNameSick=sic.lNameSick,typeBloodSick=sic.typeBloodSick,statusSick=sic.statusSick,pelephoneSick=sic.pelephoneSick };
            _sicksService.Post(sickPost);
            return Ok(_mapper.Map<SicksDto>(sickPost));

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Sicks sic)
        {
            return Ok( _sicksService.Put(id, sic));
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            _sicksService.Delete(id);
            return NoContent();
        }
    }
    }

