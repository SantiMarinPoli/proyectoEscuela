using System;
using Microsoft.AspNetCore.Mvc;
using platzi_curso_aspcore.Models;

namespace platzi_curso_aspcore.Controllers
{
    public class SchoolController: Controller
    {
        public IActionResult Index()
        {
            var school = new School();
            school.yearFoundation = 2010;
            school.schoolId = Guid.NewGuid().ToString();
            school.name = "Platzi School";
            school.City = "Bogota";
            school.Country = "Colombia";
            school.TipoEscuela = TiposEscuela.Secundaria;
            school.Direction = "Av. Siempre Viva";
            return View(school);
        }
    }
}