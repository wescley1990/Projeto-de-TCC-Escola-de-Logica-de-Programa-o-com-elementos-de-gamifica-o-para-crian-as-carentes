using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TCC.UI.Web.Controllers
{
    public class RankingController : BaseController
    {
        public RankingController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
