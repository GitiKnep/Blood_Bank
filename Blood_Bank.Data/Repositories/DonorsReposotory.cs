using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Data.Repositories
{
    public class DonorsReposotory : IDonorsRepositories
    {
        private readonly DataContext _context;
        public DonorsReposotory(DataContext context)
        {
            _context = context;
        }

        public List<Donors> GetAll()
        {
            return _context.DonorsList.ToList();

        }

        public Donors Get(int id)
        {
            return _context.DonorsList.Find(id);

        }


        public Donors Post(Donors don)
        {
            _context.DonorsList.Add(don);
            _context.SaveChanges();
            return don;
        }
        public Donors Put(int id, Donors don)
        {
            var don2 = Get(id);
            if (don2 != null)
            {
               
                don2.fNameDonor = don.fNameDonor;
                don2.lNameDonor = don.lNameDonor;
                don2.statusDonor = don.statusDonor;
                don2.pelephoneDonor = don.pelephoneDonor;
                don2.typeBloodDonor = don.typeBloodDonor;
                _context.SaveChanges();
            }
            return don2;
        }

        public void Delete(int id)
        {
            var don1 = Get(id);
            _context.DonorsList.Remove(don1);
            _context.SaveChanges();

        }
    }
}
