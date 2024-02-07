using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Data.Repositories
{
    public class SicksReposotory : ISicksRepositories
    {
        private readonly DataContext _context;
        public SicksReposotory(DataContext context)
        {
            _context = context;
        }


        public List<Sicks> GetAll()
        {
            return _context.SicksList.ToList();
        }

        public Sicks Get(int id)
        {
            return _context.SicksList.Find(id);

        }
        public Sicks Post(Sicks sic)
        {
            _context.SicksList.Add(sic);
            _context.SaveChanges();
            return sic;
        }

        public Sicks Put(int id, Sicks sic)
        {
            var sic2 = Get(id);
            if (sic2 != null) { 
            sic2.fNameSick = sic.fNameSick;
            sic2.lNameSick = sic.lNameSick;
            sic2.typeBloodSick = sic.typeBloodSick;
            sic2.pelephoneSick = sic.pelephoneSick;
            sic2.statusSick = sic.statusSick;
             _context.SaveChanges();
            }
            return sic2;
        }

        public void Delete(int id)
        {
            var sic1 =Get(id);
            _context.SicksList.Remove(sic1);
            _context.SaveChanges();

        }
    }
}
