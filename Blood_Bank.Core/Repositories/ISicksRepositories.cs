﻿using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Repositories
{
    public interface ISicksRepositories
    {
        public List<Sicks> GetAll();
        public Sicks Get(int id);
        public Sicks Post(Sicks sic);

        public Sicks Put(int id, Sicks sic);
        public void Delete(int id);
    }
}
