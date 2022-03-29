using System;
using escuelaWeb.Data;
using escuelaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace escuelaWeb.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context )
        {
            _context = context;
        }

        public IActionResult Index()
        {
           var escuela = _context.Escuelas.FirstOrDefault();

            return View(escuela);

        }
    }

}