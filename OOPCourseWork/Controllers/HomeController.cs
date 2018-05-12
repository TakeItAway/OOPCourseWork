using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OC.Data;
using OC.Data.Models;
using OC.Repository.Repositories;
using OOPCourseWork.Models;
using OOPCourseWork.ViewModels;

namespace OOPCourseWork.Controllers
{
    public class HomeController : Controller
    {
        ManualRepository _manualRepository;
        TagRepository _tagRepository;

        public HomeController(ApplicationDbContext context)
        {
            _manualRepository = new ManualRepository(context);
            _tagRepository = new TagRepository(context);
        }
        public IActionResult Index(string tagId)
        {
            IEnumerable<Manual> list = new List<Manual>();
            IEnumerable<Tag> tags = _tagRepository.GetList();

            if (tagId != null)
            {
                list = _manualRepository.GetTagManuals(tagId);
            }
            else
            {
                list = _manualRepository.GetList();
            }
            HomeIndexViewModel newModel = new HomeIndexViewModel()
            {
                Tags = tags,
                Manuals = list
            };
            return View(newModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Manual()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
