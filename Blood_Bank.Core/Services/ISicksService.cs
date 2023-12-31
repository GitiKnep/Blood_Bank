﻿using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Services
{
    public interface ISicksService
    {
       IEnumerable<Sicks> GetAll();
        Sicks Get(int id);
       Sicks Post(Sicks sic);
       Sicks  Put(int id, Sicks sic);
      void Delete(int id);
    }
}
