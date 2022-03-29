using System;
using System.Collections.Generic;
using escuelaWeb.Data;
using escuelaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace escuelaWeb.Controllers
{
    public class CursoController : Controller
    {
        private EscuelaContext _context;
        public CursoController(EscuelaContext context )
        {
            _context = context;
        }
        public IActionResult Index(string id)
        {
            if(!string.IsNullOrWhiteSpace(id))
            {
                var cursos = from cur in _context.Cursos
                             where cur.Id == id
                             select cur;
                return View(cursos.SingleOrDefault());
            }
            else
            {
                return View("MultiCurso",_context.Cursos);
            }   
        }
        public IActionResult MultiCurso()
        {
            ViewBag.CosaDinamica = "La monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiCurso",_context.Cursos);

        }

        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;
            if(ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();

                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Curso Creado";
                return View("Index",curso);
            }
            else
            {
                return View(curso);
            }

        }
    }

}