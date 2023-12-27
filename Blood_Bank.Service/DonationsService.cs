using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using Blood_Bank.Core.Services;
using Blood_Bank.Data;

namespace Blood_Bank.Service
{
    public class DonationsService : IDonationsService
    {
        private readonly IDonationsRepositories _donationsRepositories;
        public DonationsService(IDonationsRepositories donationsRepositories)
        {
            _donationsRepositories = donationsRepositories;
        }
        public IEnumerable<Donations> GetAll()
        {
            return _donationsRepositories.GetAll();
        }
        public Donations Get(int id)
        {
            return _donationsRepositories.Get(id);

        }

        public Donations Post(Donations dona)
        {
           return _donationsRepositories.Post(dona);

        }


        public Donations Put(int id, Donations dona)
        {
          return  _donationsRepositories.Put(id, dona);
        }


        public void Delete(int id)
        {
            _donationsRepositories.Delete(id);

        }
    }
}
