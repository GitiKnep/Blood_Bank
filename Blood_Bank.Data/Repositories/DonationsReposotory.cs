using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Data.Repositories
{
    public class DonationsReposotory : IDonationsRepositories
    {
        private readonly DataContext _context;
        public DonationsReposotory(DataContext context)
        {
            _context = context;
        }
        public List<Donations> GetAll()
        {
            return _context.DonationsList.ToList();
        }
        public Donations Get(int id)
        {
            return _context.DonationsList.Find(id);

        }

        public Donations Post(Donations dona)
        {
            _context.DonationsList.Add(dona);
            _context.SaveChanges();
            return dona;

        }


        public Donations Put(int id, Donations dona)
        {
            var dona2 = Get(id);
            if (dona2 != null) {
                dona2.idDonation = dona.idDonation;
                dona2.idDonor = dona.idDonor; ;
                dona2.idSick = dona.idSick;
                _context.SaveChanges();
            }
            return dona2;
        }
        

        


        public void Delete(int id)
        {
          var dona1 = Get(id);
            _context.DonationsList.Remove(dona1);
            _context.SaveChanges();

        }
    }
}
