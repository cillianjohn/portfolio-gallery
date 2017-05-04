using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioGallery.Controllers
{
    public class PortfolioController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.ProjectTitle = "Final Year Thesis";
            ViewBag.ProjectDate = "2006";
            ViewBag.Description = "<p>explorations in bent wood techniques</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "pencils: Humberto Ramos",
                "Inks: Victor Olazaba"
            };



            return View();
            
        }
    }
}