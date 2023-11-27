using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Data.Repositories
{
    public class DonorsReposotory
    {
        private readonly DataContext _context;
        public DonorsReposotory(DataContext context)
        {
            _context = context;
        }
    
        public List<Donors> GetAll()
        {
            return _context.DonorsList;

        }

        public Donors Get(int id)
        {
           return _context.DonorsList.Find(d => d.idDonor == id);
           
        }

       
        public void Post(Donors don)
        {
            _context.DonorsList.Add(don);

        }
        public void Put(int id, Donors don)
        {
            var don2 = _context.DonorsList.Find(d => d.idDonor == id);
            don2.idDonor = don.idDonor;
            don2.fNameDonor = don.fNameDonor;
            don2.lNameDonor = don.lNameDonor;
            don2.statusDonor = don.statusDonor;
            don2.pelephoneDonor = don.pelephoneDonor;
            don2.typeBloodDonor = don.typeBloodDonor;
           
        }

        public void Delete(int id)
        {
            var don1 = _context.DonorsList.Find(v => v.idDonor == id);
            _context.DonorsList.Remove(don1);
          
        }
    }
}
