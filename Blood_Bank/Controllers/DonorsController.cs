﻿using Blood_Bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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