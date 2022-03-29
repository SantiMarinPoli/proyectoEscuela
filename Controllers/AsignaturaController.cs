using System;
using System.Collections.Generic;
using escuelaWeb.Data;
using escuelaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace escuelaWeb.Controllers
{
    public class AsignaturaController : Controller
    {
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context )
        {
            _context = context;
        }
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{idAsignatura}")]
        public IActionResult Index(string idAsignatura)
        {
            if(!string.IsNullOrWhiteSpace(idAsignatura))
            {
                var asignatura = from asig in _context.Asignaturas
                             where asig.Id == idAsignatura
                             select asig;
                return View(asignatura.SingleOrDefault());
            }
            else
            {
                return View("MultiAsignatura",_context.Asignaturas);
            }   
        }
        public IActionResult MultiAsignatura()
        {
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura",_context.Asignaturas);

        }
    }

}