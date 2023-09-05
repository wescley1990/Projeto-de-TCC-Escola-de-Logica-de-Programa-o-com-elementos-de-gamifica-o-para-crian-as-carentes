using Microsoft.AspNetCore.Mvc;

namespace TCC.UI.Web.Controllers
{
    public class RankingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
