using Microsoft.AspNetCore.Mvc;

namespace TCC.UI.Web.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
