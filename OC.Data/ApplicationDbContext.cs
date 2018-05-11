using Microsoft.EntityFrameworkCore;
using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Manual> Manuals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ManualTag> ManualTags { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OOPCourseWorkDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
