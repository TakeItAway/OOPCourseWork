using OC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPCourseWork.ViewModels
{
    public class HomeIndexViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<Manual> Manuals { get; set; }
    }
}
