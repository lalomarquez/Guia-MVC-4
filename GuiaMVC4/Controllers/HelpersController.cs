using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuiaMVC4.Models;

namespace GuiaMVC4.Controllers
{
    public class HelpersController : Controller
    {
        //
        // GET: /Helpers/
        public ActionResult InlineHTMLhelper()
        {
            return View();
        }

        [HttpGet] 
        public ActionResult StronglyTypedHTMLHelper()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StronglyTypedHTMLHelper(Student stud)
        {
            return View();
        }
    }
}
