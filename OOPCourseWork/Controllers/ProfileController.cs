using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OOPCourseWork.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateManual()
        {
            return View();
        }
        public IActionResult EditManual()
        {
            return View();
        }
    }
}