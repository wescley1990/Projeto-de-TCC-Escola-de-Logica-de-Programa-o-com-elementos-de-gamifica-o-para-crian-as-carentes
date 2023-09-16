using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Application.Interfaces;

namespace TCC.UI.Web.Controllers
{
    public class LojaController : Controller
    {
        private readonly IItemLojaAppService _lojaAppService;

        public LojaController(IItemLojaAppService lojaAppservice)
        {
            _lojaAppService = lojaAppservice;
        }

        [AllowAnonymous]
        [HttpGet("Loja")]
        public async Task<IActionResult> Index()
        {
            return View(await _lojaAppService.GetAll());
        }
    }
}
