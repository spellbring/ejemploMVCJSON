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

        public JsonResult GetCategorias()
        {
            var cdal = new CategoriasDAL();
            //var objetos = cdal.GetCategorias();

            var objetos = new Categorias();
            var listaObjetos = new List<Categorias>();

            objetos.CategoryID = 1;
            objetos.CategoryName = "Nombre";

            listaObjetos.Add(objetos);

            return Json(listaObjetos.ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}
