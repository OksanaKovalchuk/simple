﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simple_asp_web.Controllers
{
    public class ValuesController : Controller
    {
        //Get api/values
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2" };
        }
        // GET: Values
        public ActionResult Index()
        {
            return View();
        }

        // GET: Values/Details/5     api/values/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Values/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Values/Create api/values
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

        // GET: Values/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Values/Edit/5
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

        // GET: Values/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Values/Delete/5
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
