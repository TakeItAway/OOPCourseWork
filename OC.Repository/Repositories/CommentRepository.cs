using OC.Data;
using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _context.Comments.Add(item);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var comment = _context.Comments.Find(id);
            _context.Remove(comment);
        }

        public Comment GetById(string id)
        {
            return _context.Comments.Find(id);
        }

        public IEnumerable<Comment> GetList()
        {
            return _context.Comments;
        }

        public IEnumerable<Comment> GetManualComments(string id)
        {
            return _context.Comments.Where(comment => comment.ManualId == id);
        }

        public void Update(Comment item)
        {
            _context.Comments.Update(item);
        }
    }
}
