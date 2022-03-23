using System;
using System.Collections.Generic;
using escuelaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace escuelaWeb.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View( new Alumno{
                        UniqueId = Guid.NewGuid().ToString(),
                        Nombre = "EL PEPE PEREZ"});
        }
        public IActionResult MultiAlumno()
        {
            var listaAlumno = new List<Alumno>(){
                    new Alumno{
                        UniqueId = Guid.NewGuid().ToString(),
                        Nombre = "Peter Parker"
                    },
                    new Alumno{
                        UniqueId = Guid.NewGuid().ToString(),
                        Nombre = "Tony Stark"
                    },
                     new Alumno{
                        UniqueId = Guid.NewGuid().ToString(),
                        Nombre = "Bill Gates"
                    },
                     new Alumno{
                        UniqueId = Guid.NewGuid().ToString(),
                        Nombre = "Albert Einstein"
                    }

            };
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno",listaAlumno);

        }
    }

}