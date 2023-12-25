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
            return _context.DonationsList.ToList().Find(d => d.idDonation == id);

        }

        public void Post(Donations dona)
        {
            _context.DonationsList.Add(new Donations
            {
                idDonation =_context.CntDonation++,
                  idDonor = dona.idDonor,
                 idSick = dona.idSick

        });

        }


        public void Put(int id, Donations dona)
        {
            var dona2 = _context.DonationsList.ToList().Find(d => d.idDonation == id);
            dona2.idDonation = dona.idDonation;
            dona2.idDonor = dona.idDonor; ;
            dona2.idSick = dona.idSick;

        }


        public void Delete(int id)
        {
            var dona1 = _context.DonationsList.ToList().Find(v => v.idDonation == id);
            _context.DonationsList.Remove(dona1);

        }
    }
}
