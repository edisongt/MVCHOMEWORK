using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHOMEWORK.Models;

namespace MVCHOMEWORK.Controllers
{
    public class GenneralListController : Controller
    {
         private CustomerEntities db = new CustomerEntities();
        // GET: GenneralList
        public ActionResult Index()
        {
            var GenneralList = db.vw_CustomerContactorBankCount;
            return View(GenneralList.ToList());
        }

        // GET: GenneralList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenneralList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenneralList/Create
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

        // GET: GenneralList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenneralList/Edit/5
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

        // GET: GenneralList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenneralList/Delete/5
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
