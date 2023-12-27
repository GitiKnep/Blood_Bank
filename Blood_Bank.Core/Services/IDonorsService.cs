using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Services
{
    public interface IDonorsService
    {
     IEnumerable<Donors> GetAll();
      Donors Get(int id);
      Donors Post(Donors don);
      Donors Put(int id, Donors don);
      void Delete(int id);
    }
}
