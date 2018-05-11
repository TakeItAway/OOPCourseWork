
using OC.Data;
using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OC.Repository.Repositories
{
    public class LikeRepository : IRepository<Like>
    {
        private ApplicationDbContext _context;

        public LikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Like item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Like GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Like> GetList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetManualLikes(string id)
        {
            throw new NotImplementedException();
        }

        public void Save(Like item)
        {
            throw new NotImplementedException();
        }

        public void Update(Like item)
        {
            throw new NotImplementedException();
        }
    }
}