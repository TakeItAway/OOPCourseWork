using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPCourseWork.ViewModels
{
    public class UsersIndexViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}
