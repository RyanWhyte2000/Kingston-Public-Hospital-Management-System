using Microsoft.AspNetCore.Mvc;

namespace KPH_Management_System.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
