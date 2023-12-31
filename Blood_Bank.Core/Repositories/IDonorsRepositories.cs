﻿using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Repositories
{
    public interface IDonorsRepositories
    {
        List<Donors> GetAll();
        Donors Get(int id);
      Donors Post(Donors don);

      Donors Put(int id, Donors don);
      public  void Delete(int id);

    }
}
