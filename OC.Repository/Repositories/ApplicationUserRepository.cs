using OC.Data;
using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OC.Repository.Repositories
{
    public class ApplicationUserRepository : IRepository<ApplicationUser>
    {
        private ApplicationDbContext _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(ApplicationUser item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save(ApplicationUser item)
        {
            throw new NotImplementedException();
        }

        public void Update(ApplicationUser item)
        {
            throw new NotImplementedException();
        }
    }
}