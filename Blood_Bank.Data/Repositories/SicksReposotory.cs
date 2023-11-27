using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Data.Repositories
{
    public class SicksReposotory
    {
        private readonly DataContext _context;
        public SicksReposotory(DataContext context)
        {
            _context = context;
        }

     
        public List<Sicks> GetAll()
        {
            return _context.SicksList;
        }

        public Sicks Get(int id)
        {
            return _context.SicksList.Find(s => s.idSick == id);
           
        }
        public void Post(Sicks sic)
        {
            _context.SicksList.Add(sic);

        }

        public void Put(int id, Sicks sic)
        {
            var sic2 = _context.SicksList.Find(s => s.idSick == id);
            sic2.idSick = sic.idSick;
            sic2.fNameSick = sic.fNameSick;
            sic2.lNameSick = sic.lNameSick;
            sic2.typeBloodSick = sic.typeBloodSick;
            sic2.pelephoneSick = sic.pelephoneSick;
            sic2.statusSick = sic.statusSick;
        }

        public void Delete(int id)
        {
            var sic1 = _context.SicksList.Find(s => s.idSick == id);
            _context.SicksList.Remove(sic1);
         
        }
    }
}
