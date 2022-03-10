using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_curso_aspcore.Models;

namespace platzi_curso_aspcore.Controllers
{
    public class AsignaturaController: Controller
    {
        private SchoolContext _context;
        public AsignaturaController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault());
        }
        public IActionResult MultiAsignatura()
        {
          /*  var listCourse = new List<Course>{
                new Course{Nombre = "Programming",
                           UniqueId = Guid.NewGuid().ToString()
                },
                new Course{Nombre = "Math",
                           UniqueId = Guid.NewGuid().ToString()
                },
                new Course{Nombre = "Sciences",
                           UniqueId = Guid.NewGuid().ToString()
                }, 
                new Course{Nombre = "Artistic",
                           UniqueId = Guid.NewGuid().ToString()
                }
            } ;*/

            ViewBag.date = DateTime.Now;
            
            return View("MultiAsignatura",_context.Asignaturas);
        }
    }
}