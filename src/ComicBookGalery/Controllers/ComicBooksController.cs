using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGalery.Controllers
{
    public class ComicBooksController : Controller
    {
        //public string Detail()
        //{
        //    return "Hello from the comic books controller !";
        //}
        // ContentResult, RedirectResult : ActionResult
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                //return new RedirectResult("/");
                return Redirect("/");
            }
            //return new ContentResult()
            //{
            //    Content = "Hello from the comic books controller !"
            //};
            return Content("Hello from the comic books controller !");
        }
    }
}