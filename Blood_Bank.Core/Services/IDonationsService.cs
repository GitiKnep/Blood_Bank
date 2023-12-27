using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Services
{
    public interface IDonationsService
    {
       IEnumerable<Donations> GetAll();
       Donations Get(int id);
       Donations Post(Donations dona);
       Donations Put(int id, Donations dona);
        void Delete(int id);

    }
}
