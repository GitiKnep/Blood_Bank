using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Repositories
{
    public interface IDonationsRepositories
    {
        public List<Donations> GetAll();
        public  Donations Get(int id);
        public Donations Post(Donations dona);

        public Donations Put(int id, Donations dona);
       public void Delete(int id);

    }
}
