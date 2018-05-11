using OC.Data;
using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Repository.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Comment item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetManualComments(string id)
        {
            throw new NotImplementedException();
        }

        public void Save(Comment item)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment item)
        {
            throw new NotImplementedException();
        }
        
    }
}
