using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Mostrar()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }
        //Procesa datos
        [HttpPost]
        public ActionResult Agregar(int idVideo, string titulo, int repro, string url)
        {
            //Guardar en la base de datos 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("insert into video values (@idVideo, @titulo,@repro,@url)",
            CommandType.Text,
            parametros);
            RedirectToAction("Index", "Home");
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
        //Procesa datos
        [HttpPost]
        public ActionResult Eliminar(int idVideo)
        {
            //Guardar en la base de datos 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarSentencia("delete from video where idVideo=@idVideo",
            CommandType.Text,
            parametros);
            RedirectToAction("Index", "Home");
            return View();
        }
        public ActionResult Modificar()
        {
            return View();
        }
    }
}
