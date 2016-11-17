using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using simple_asp_web.Models;
using System.Web.Mvc;

namespace simple_asp_web.Controllers
{
    //Download Telerik Fiddler Web Debugger to check http requests results
    //[Authorize]
    public class ValuesController : ApiController
    {
        //Determining Generic class strings
        static List<string> strings = new List<string>()
        {
            "value0","value1", "value2"
        };

        //GET api/values
        public IEnumerable<string> Get()
        {
            return strings;
        }
        
        //GET api/values/5
        public string Get(int id)
        {
            return strings[id];
        }
        
        //POST api/values
        public void Post([FromBody] string value)
        {
            strings.Add(value);
        }
        
        //PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            strings[id] = value;
        }

        //DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
        // GET: Values
        //public ActionResult Index()
        //{
        //    return "value";
        //}

        // GET: Values/Details/5     api/values/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Values/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Values/Create api/values
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Values/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: Values/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Values/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Values/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
