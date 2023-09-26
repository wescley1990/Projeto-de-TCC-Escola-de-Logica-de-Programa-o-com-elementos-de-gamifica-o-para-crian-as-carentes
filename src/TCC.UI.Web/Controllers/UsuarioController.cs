using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TCC.Application.Interfaces;
using TCC.Domain.Models;

namespace TCC.UI.Web.Controllers
{
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [Authorize]
        [HttpGet("Usuarios")]
        public async Task<IActionResult> Index()
        {
            var result = await _usuarioAppService.GetAll();
            return View("/Views/Ranking/Index.cshtml", result);
        }
    }
}
