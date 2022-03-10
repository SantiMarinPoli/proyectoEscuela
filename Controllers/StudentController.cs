using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_curso_aspcore.Models;

namespace platzi_curso_aspcore.Controllers
{
    public class StudentController: Controller
    {

        private SchoolContext _context;
        public StudentController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.FirstOrDefault());
        }
        public IActionResult MultiStudent()
        {
            var listStudent = GenerarAlumnosAlAzar();

            ViewBag.date = DateTime.Now;
            
            return View("MultiStudent",listStudent);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}