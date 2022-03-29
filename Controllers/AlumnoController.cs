using System;
using System.Collections.Generic;
using escuelaWeb.Data;
using escuelaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace escuelaWeb.Controllers
{
    public class AlumnoController : Controller
    {
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context )
        {
            _context = context;
        }
        public IActionResult Index(string id)
        {
            if(!string.IsNullOrWhiteSpace(id))
            {
                var alumnos = from alm in _context.Alumnos
                             where alm.Id == id
                             select alm;
                return View(alumnos.SingleOrDefault());
            }
            else
            {
                return View("MultiAlumno",_context.Alumnos);
            }   
        }
        public IActionResult MultiAlumno()
        {
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno",_context.Alumnos);

        }
    }

}