using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Application.Interfaces;
using TCC.Domain.Models;

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
        [HttpGet("Cursos/{name}")]
        public async Task<IActionResult> Detalhes(string name)
        {
            if (string.IsNullOrEmpty(name)) 
            {
                return NotFound();
            }

            var cursoViewModel = await _cursoAppService.GetByName(name);

            if (cursoViewModel is null)
            {
                return NotFound();
            }

            return View(cursoViewModel);
        }

        [HttpPost("Cursos/load")]
        public IActionResult Load() 
        {
            var curso = new Curso(
                Guid.NewGuid(),
                "Variáveis",
                "Aprenda os fundamentos essenciais para utilizar variáveis",
                Domain.Enums.Nivel.Iniciante
                )
            {
                Aulas = new List<Aula>()
                {
                    new Aula()
                    {
                        Id = Guid.NewGuid(),
                        Descricao = "",
                        ContentUrl = "pdf/Variaveis/Variaveis1.pdf",
                        Nome = "Introdução às Variáveis",
                        QtdMoedas = 10,
                        Xp = 1000,
                        Exercicios = new List<Exercicio>()
                        {
                            new Exercicio()
                            {
                                Enunciado = "Por que as variáveis são usadas na programação?",
                                AlternativaA = "",
                                AlternativaB = "",
                                AlternativaC = "",
                                AlternativaD = "Para evitar o uso de números.",
                                Resposta = "B) Para armazenar e manipular informações."
                            }
                        }
                    },
                    new Aula()
                    {
                         Id = Guid.NewGuid(),
                        Descricao = "",
                        ContentUrl = "pdf/Variaveis/Variaveis1.pdf",
                        Nome = "Introdução às Variáveis",
                        QtdMoedas = 10,
                        Xp = 1000
                    },
                    new Aula()
                    {
                         Id = Guid.NewGuid(),
                        Descricao = "",
                        ContentUrl = "pdf/Variaveis/Variaveis1.pdf",
                        Nome = "Introdução às Variáveis",
                        QtdMoedas = 10,
                        Xp = 1000
                    }
                },
                Duracao = 200,
                QtdMoeda = 30,
                Xp = 5000
            };

            _cursoAppService.Add(curso);

            return Ok(curso);
        }
    }
}
