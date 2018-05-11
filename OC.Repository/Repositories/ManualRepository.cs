using OC.Data;
using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Repository.Repositories
{
    public class ManualRepository : IRepository<Manual>
    {
        private ApplicationDbContext _context;

        public ManualRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Manual item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Manual GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manual> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save(Manual item)
        {
            throw new NotImplementedException();
        }

        public void Update(Manual item)
        {
            throw new NotImplementedException();
        }
    }
}
