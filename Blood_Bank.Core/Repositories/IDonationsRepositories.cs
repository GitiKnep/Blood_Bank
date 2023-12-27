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
        List<Donations> GetAll();
        Donations Get(int id);
       Donations Post(Donations dona);

      Donations Put(int id, Donations dona);
       public void Delete(int id);

    }
}
