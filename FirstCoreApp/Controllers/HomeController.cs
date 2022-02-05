using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
    public class HomeController : Controller
    {
        NewsDBContext db;
        public HomeController(NewsDBContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var result = db.Categories.ToList();
            return View(result);
        }
        public ActionResult News(int id)
        {
            Categories c = db.Categories.Find(id);
           ViewBag.Cat= c.Name;
            var result = db.News.Where(x => x.CategoryId == id).OrderByDescending(x => x.Date).ToList();
            return View(result);
        }
        public ActionResult DeleteNews(int id)
        {
           var news= db.News.Find(id);
            db.News.Remove(news);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
