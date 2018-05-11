using OC.Data;
using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OC.Repository.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private ApplicationDbContext _context;

        public TagRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Tag item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Tag GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetManualTags(string id)
        {
            throw new NotImplementedException();
        }

        public void Save(Tag item)
        {
            throw new NotImplementedException();
        }

        public void Update(Tag item)
        {
            throw new NotImplementedException();
        }
    }
}