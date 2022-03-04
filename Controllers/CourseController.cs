using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_curso_aspcore.Models;

namespace platzi_curso_aspcore.Controllers
{
    public class CourseController: Controller
    {

        public IActionResult Index()
        {
            return View( new Course{Nombre = "Artistic",
                           UniqueId = Guid.NewGuid().ToString()}
                        );
        }
        public IActionResult MultiCourse()
        {
            var listCourse = new List<Course>{
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
            } ;

            ViewBag.date = DateTime.Now;
            
            return View("MultiCourse",listCourse);
        }
    }
}