
using BootsrapDemoTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BootsrapDemoTest.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            //var project = new FirstProject() { id = 1, name = "asdf" };
            //return BadRequest("");
            return View();
        }

        public ActionResult p1()
        {
            var project = new FirstProject() { id = 1, name = "asdf" };
            return View(project);
        }
        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album {Title = "Product" + i });
            }
           //ViewBag.Albums = albums;
            return View(albums);
        }
    }
}