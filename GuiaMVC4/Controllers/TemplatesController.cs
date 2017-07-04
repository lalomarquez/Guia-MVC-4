using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuiaMVC4.Models;

namespace GuiaMVC4.Controllers
{
    public class TemplatesController : Controller
    {
        //
        // GET: /Templates/Details
        public ActionResult Details(int id)
        {
            SampleDBContext db = new SampleDBContext();
            tblEmployee emp = db.tblEmployee.Single(x => x.Id == id);

            return View(emp);
        }

    }
}
