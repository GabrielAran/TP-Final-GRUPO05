using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_final.Models;

namespace Proyecto_final.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Inmobiliaria()
        {
            ViewBag.Lista = BD.ObtenerTodosInmuebles();
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario miUsuario)
        {
            Usuario a = BD.LogIn(miUsuario);
            if (a == null)
            {
                ViewBag.Error = "Usuario y/o contraseña mal ingresado";
                return View("Login");
            }
            else
            {
                Session["nombreUsuario"] = a.NombreDeUsuario;
                Session["Contraseña"] = a.Contraseña;
                return RedirectToAction("Inmobiliaria");
            }
        }
    }
}