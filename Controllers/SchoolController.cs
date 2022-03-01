using Microsoft.AspNetCore.Mvc;

namespace platizi_curso_aspcore.Controllers
{
    public class SchoolController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}