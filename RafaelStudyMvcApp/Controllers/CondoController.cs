using System;
using System.Collections.Generic;
using System.Web.Mvc;
using RafaelStudyMvcApp.Filters;

namespace RafaelStudyMvcApp.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class CondoController : Controller
    {
        // GET /Condo

        [Log]
        public ActionResult Search(string Name = "Portomare")
        {
            throw new Exception("Error!");

            //return Content("This is the condo " + " " + Server.HtmlEncode(Name));

            //return RedirectPermanent("www.google.com");
            //return RedirectToAction("Index", "Home", new {name = Name});
            //return RedirectToRoute("Default", new {controller = "Home", action = "About"});
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //return Json(new {name = Name, lastname = "Condominio"}, JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public ActionResult Search()
        //{
        //    return Content("This is the condo ");
        //}

    }
}
