using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWind.Models;

namespace NorthWind.Controllers
{
    public class CategoriesController : Controller
    {
        //
        // GET: /Categories/

        public ActionResult Index()
        {
            var cdal = new CategoriasDAL();
            var objetos = cdal.Obtener(0);
            ViewBag.ListCategorias = objetos;
            return View();
        }
        public JsonResult Obtener()
        {
            var cdal = new CategoriasDAL();
            var objetos = cdal.Obtener(0);

            return Json(objetos.ToList(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Guardar(string nombre, string descripcion)
        {
            var mensaje = "";

            try
            {
                //int length = file.ContentLength;
                //byte[] buffer = new byte[length];
                //file.InputStream.Read(buffer, 0, length);
                var catDAL = new CategoriasDAL();
                var sql = "INSERT INTO NORTHWIND.DBO.CATEGORIES(CATEGORYNAME,DESCRIPTION)" +
                          "VALUES(@CATEGORIENAME, @DESCRIPTION) ";
                var cmd = catDAL.ExecuteQuery(sql);
               
                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@CATEGORIENAME", nombre);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", descripcion);
                    //cmd.Parameters.AddWithValue("@PICTURE", buffer);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        mensaje = "OK";
                    }
                    else
                    {
                        mensaje = "Error, no se pudo insertar el registro en la base de datos, comuníquese con el administrador.";
                    }

                }

            }
            catch(Exception ex){

                mensaje = "Error: "+ex.Message;
            }
                
                

            return Json(mensaje, JsonRequestBehavior.AllowGet);
        }

    }
}
