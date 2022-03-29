using System;
using System.Collections.Generic;
using escuelaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace escuelaWeb.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View( new Asignatura{
                        Id = Guid.NewGuid().ToString(),
                        Nombre = "Programacion"});
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignatura = new List<Asignatura>(){
                    new Asignatura{
                        Id = Guid.NewGuid().ToString(),
                        Nombre = "Programacion"
                    },
                    new Asignatura{
                        Id = Guid.NewGuid().ToString(),
                        Nombre = "Matematica"
                    },
                     new Asignatura{
                        Id = Guid.NewGuid().ToString(),
                        Nombre = "Ingles"
                    },
                     new Asignatura{
                        Id = Guid.NewGuid().ToString(),
                        Nombre = "Artistica"
                    }

            };
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura",listaAsignatura);

        }
    }

}