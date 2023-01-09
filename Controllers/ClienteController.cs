using Microsoft.AspNetCore.Mvc;

namespace paginaWeb.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
