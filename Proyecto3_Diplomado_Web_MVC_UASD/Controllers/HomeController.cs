using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto3_Diplomado_Web_MVC_UASD.Models;

namespace Proyecto3_Diplomado_Web_MVC_UASD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var personas = new List<Persona>
            {
                new Persona {Cedula="0001", Nombre="Johanser", Sexo="Masculino", Direccion="Tamayo"},
                new Persona {Cedula="2023", Nombre="Mercedes", Sexo="Femenina", Direccion="Barahona"},
                new Persona {Cedula="0123", Nombre="Juan", Sexo="Masculino", Direccion="Fondo Negro"},
                new Persona {Cedula="1312", Nombre="Carla", Sexo="Femenina", Direccion="Bani"},
            };
            return View(personas);
        }
    }
}