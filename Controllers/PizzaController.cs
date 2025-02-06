using Microsoft.AspNetCore.Mvc;

namespace PizzariaAspNet.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
