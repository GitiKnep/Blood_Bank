﻿using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Services
{
    public interface IDonorsService
    {
     public   IEnumerable<Donors> GetAll();
       public Donors Get(int id);
       public void Post(Donors don);
       public void Put(int id, Donors don);
       public void Delete(int id);
    }
}
