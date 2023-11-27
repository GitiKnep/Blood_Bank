using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank.Data.Repositories;
using Blood_Bank.Core.Repositories;

namespace Blood_Bank.Service
{
    public class DonorsService
    {
        private readonly IDonorsRepositories _donorsRepositories;
        public DonorsService(IDonorsRepositories donorsRepositories)
        {
            _donorsRepositories = donorsRepositories;
        }
        public IEnumerable<Donors> GetAll()
        {
            return _donorsRepositories.GetAll();
        }
        public Donors Get(int id)
        {
            return _donorsRepositories.Get(id);

        }

        public void Post(Donors don)
        {
            _donorsRepositories.Post(don);

        }


        public void Put(int id, Donors don)
        {
            _donorsRepositories.Put(id, don);
        }


        public void Delete(int id)
        {
            _donorsRepositories.Delete(id);

        }
    }
}

