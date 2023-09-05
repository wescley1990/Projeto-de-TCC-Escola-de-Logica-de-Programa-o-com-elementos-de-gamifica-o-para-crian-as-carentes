using Microsoft.AspNetCore.Mvc;

namespace TCC.UI.Web.Controllers
{
    public class LojaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
