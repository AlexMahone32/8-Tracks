using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationExample.Controllers
{
    public class UniversityController : Controller
    {
        //
        // GET: /University/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(ValidationExample.Models.University u) 
        {
            
            int cnt = ModelState.Count;

            return View("Index");
        }

    }
}
