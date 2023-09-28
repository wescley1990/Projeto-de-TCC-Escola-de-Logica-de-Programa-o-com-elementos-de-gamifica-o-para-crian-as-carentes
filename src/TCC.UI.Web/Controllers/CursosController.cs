using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Application.Interfaces;

namespace TCC.UI.Web.Controllers
{
    public class CursosController : BaseController
    {
        private readonly ICursoAppService _cursoAppService;

        public CursosController(ICursoAppService cursoAppService)
        {
            _cursoAppService = cursoAppService;
        }
        
        [AllowAnonymous]
        [HttpGet("Cursos")]
        public async Task<IActionResult> Index()
        {
            return View(await _cursoAppService.GetAll());
        }

        [Authorize]
        [HttpGet("Cursos/{id:guid}")]
        public async Task<IActionResult> Detalhes(Guid? id)
        {
            if (id is null) 
            {
                return NotFound();
            }

            var cursoViewModel = await _cursoAppService.GetById(id.Value);

            if (cursoViewModel is null)
            {
                return NotFound();
            }

            return View(cursoViewModel);
        }
    }
}
