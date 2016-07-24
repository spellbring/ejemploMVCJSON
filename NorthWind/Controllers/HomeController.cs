using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWind.Models;



namespace NorthWind.Controllers
{
    public class HomeController : Controller
    {
       
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult Obtener()
        {
            var cdal = new CategoriasDAL();
            var objetos = cdal.Obtener(0);

            return Json(objetos.ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}
