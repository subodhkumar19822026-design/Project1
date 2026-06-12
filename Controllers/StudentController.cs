using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
