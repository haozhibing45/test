using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4NetIntoMongodb.Controllers
{
    public class loggerController : Controller
    {
        // GET: logger
        public ActionResult Index()
        {
            return View();
        }

        // GET: logger/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: logger/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: logger/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: logger/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: logger/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: logger/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: logger/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
