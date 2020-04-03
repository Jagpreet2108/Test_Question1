using Microsoft.AspNetCore.Mvc;

namespace Question1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}