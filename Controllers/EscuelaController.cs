using System;
using escuelaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace escuelaWeb.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            ViewBag.CosaDinamica = "La monja";

            return View(escuela);

        }
    }

}