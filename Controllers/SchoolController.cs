using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_curso_aspcore.Models;

namespace platzi_curso_aspcore.Controllers
{
    public class SchoolController: Controller
    {
        private SchoolContext _context;
        public SchoolController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var school =  _context.Escuelas.FirstOrDefault();
            return View(school);
        }


    }
}