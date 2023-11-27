using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Repositories
{
    public interface ISicksRepositories
    {
        List<Sicks> GetAll();
        Sicks Get(int id);
        void Post(Sicks sic);

        void Put(int id, Sicks sic);
        void Delete(int id);
    }
}
