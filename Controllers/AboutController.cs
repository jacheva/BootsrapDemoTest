using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootsrapDemoTest.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BootsrapDemoTest.Controllers
{
    public class AboutController : Controller
    {
        //public IActionResult Index()
        //{

        //    //  return  RedirectToAction("Index", "Projects", new { page=1, sortBy = "name"});
        //    return View();
        //}
       
        public IActionResult Index()
        {
            ViewBag.Weapon = "sward";
            return View();
        }

    }
}