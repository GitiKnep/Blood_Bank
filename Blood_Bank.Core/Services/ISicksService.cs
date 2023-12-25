using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Services
{
    public interface ISicksService
    {
      public  IEnumerable<Sicks> GetAll();
       public Sicks Get(int id);
       public void Post(Sicks sic);
       public void Put(int id, Sicks sic);
       public void Delete(int id);
    }
}
