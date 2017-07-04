using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuiaMVC4.Models
{
    public class HomeController : Controller
    {
        #region Metodo dummy para ver que jale la app.                
        /*
         * http://localhost:.../Home/Index1
         * Server: http://localhost:...
         * Controller: Home
         * name: Index
        */        
        public string Index1()
        {
            return "Hello MVC app";
            //return typeof(Controller).Assembly.GetName().Version.ToString();// pa saber la version
        }
        /*
         * http://localhost:51336/Home/Index2/10?name=lalo
         */
        public string Index2(string id, string name)
        {
            return "Id es: " + id + " y tu nombre es: " + name;
        }        
        public ActionResult Dummy()
        {
            return View();
        }
        #endregion

        #region Types of Action Results

        //ViewResult
        public ActionResult AR_ViewResult()
        {
            return View();
        }

        //ContentResult
        public ActionResult AR_ContentResult()
        {
            return Content("This method returns plain text.");
        }

        //JsonResult
        public ActionResult AR_JsonResult()
        {
            var employee = new
            {
                Name = "Eduardo",
                Age = "30",
                Occupation = "Software Developer"
            };

            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        //FileResult
        public ActionResult AR_FileResult()
        {
            return File(Server.MapPath("~/App_Data/documentation.pdf"),
                        contentType: "application/pdf",
                        fileDownloadName: "documentation.pdf");
        }

        //RedirectToAction
        public ActionResult AR_RedirectToAction()
        {
            return RedirectToAction("Contact");
        }
        public ActionResult Contact()
        {
            return Content("This is the redirected Contact method.");
        }  
        #endregion

        #region Action And Action Selectors

        [ActionName("PagInicio")]
        public string Accion()
        {
            return "This is ASP.Net MVC ActionName";
        }

        [ActionName("GetDetail")]
        public string Detail()
        {
            return "This is detail at " + DateTime.Now.ToString("T");
        }

        [NonAction]
        public string GetTimeAsString()
        {
            return "This is detail at " + DateTime.Now.ToString("T");
        }

        [HttpGet]
        public ActionResult Editar(string nombre)
        {
            ViewBag.HttpGet = nombre;//Request.QueryString["nombre"];
            return View();
        }

        //[HttpPost]
        //public ActionResult Editar(int id)
        //{
        //    ViewBag.HttpPost = id;
        //    return View();
        //}

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetAndPostAction()
        {
            return RedirectToAction("Index");
        }

        #endregion

        #region Formas de pasar datos del Controlador a la Vista.
        public ActionResult Vista_ViewBag()
        {
            DateTime aDay = DateTime.Now; 
            ViewBag.Mensaje = "Mensaje ViewBag desde HomeController";
            ViewBag.FechaAlta = aDay;
            ViewBag.Vista = "ViewBag";

            ViewBag.Ciudades = new List<string>()
            {
            "Monterrey", "Guadalajara", "Saltillo","Monclova"        
            };
            return View();
        }

        public ActionResult Vista_ViewData()
        {
            DateTime aDay = DateTime.Now; 
            ViewData["Mensaje"] = "Mensaje ViewData desde HomeController";
            ViewData["FechaAlta"] = aDay;
            ViewData["Vista"] = "ViewData";

            ViewData["Ciudades"] = new List<string>()
            {
            "Monterrey", "Guadalajara", "Saltillo","Monclova"        
            };
            return View();
        }

        public ActionResult Vista_TempData()
        {
            DateTime aDay = DateTime.Now;
            TempData["Mensaje"] = "Mensaje TempData desde HomeController";
            TempData["FechaAlta"] = aDay;
            TempData["Vista"] = "TempData";

            var Ciudades = new List<string>()
            {
            "Monterrey", "Guadalajara", "Saltillo","Monclova"        
            };

            TempData["Ciudades"] = Ciudades;

            return RedirectToAction("Vista_TempData2");
        }

        public ActionResult Vista_TempData2()
        {
            string data;

            if (TempData["myData"] != null)
                data = TempData["myData"] as string;

            TempData.Keep();

            return View();
        }

        public ActionResult Vista_ViewModel()
        {
            DateTime aDay = DateTime.Now;            
            List<Ciudad> lsciudad = new List<Ciudad>();            
            lsciudad.Add(new Ciudad("Monterrey"));
            lsciudad.Add(new Ciudad("Guadalajara"));
            lsciudad.Add(new Ciudad("Saltillo"));
            lsciudad.Add(new Ciudad("Monclova"));

            Usuario data = new Usuario();
            data.Mensaje = "Mensaje ViewModel desde HomeController";
            data.FechaAlta = aDay;
            data.Vista = "ViewModel";
            data.ListaCiudades = lsciudad;
          
            return View(data);
        }

        #endregion

        #region Integrando Modelo-Vista-Controlador

        public ActionResult Estudiantes()
        {
            var studentList = new List<Student>{ 
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 } 
                        };

            return View(studentList);
        }

        #endregion











        // GET: /Home/      
        public ActionResult Index()
        {
            return View();
        }
    }
}
