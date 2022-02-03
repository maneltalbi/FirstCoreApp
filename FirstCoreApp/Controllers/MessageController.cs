using FirstCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
    public class MessageController : Controller
    {
        NewsDBContext db;
        public MessageController(NewsDBContext context)
        {
            db = context;
        }
        // GET: MessageController
        public ActionResult Index()
        {
            return View(db.ContactUs.ToList());
        }
       
        // GET: MessageController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
