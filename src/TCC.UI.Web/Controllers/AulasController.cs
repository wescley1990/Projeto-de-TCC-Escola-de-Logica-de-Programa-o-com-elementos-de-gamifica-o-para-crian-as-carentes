using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Application.Interfaces;

namespace TCC.UI.Web.Controllers
{
    public class AulasController : Controller
    {
        private readonly IAulaAppService _aulaAppService;

        public AulasController(IAulaAppService aulaAppService)
        {
            _aulaAppService = aulaAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet("Aulas/{name}")]
        public async Task<IActionResult> Detalhes(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return NotFound();
            }

            var aulaViewModel = await _aulaAppService.GetByName(name);

            if (aulaViewModel is null)
            {
                return NotFound();
            }

            return View(aulaViewModel);
        }
    }
}
