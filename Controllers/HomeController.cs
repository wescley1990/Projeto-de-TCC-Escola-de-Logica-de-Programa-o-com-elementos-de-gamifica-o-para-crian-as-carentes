using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TCC.Models;
using TCC.ViewModels; // Certifique-se de que o namespace esteja correto e inclua sua ViewModel de login

namespace TCC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cursos()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel()); // Certifique-se de que a ViewModel esteja corretamente definida
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aqui você deve adicionar a lógica para verificar as credenciais do usuário
                // Substitua este exemplo por sua própria lógica de autenticação

                if (model.UserName == "usuario" && model.Password == "senha")
                {
                    // Autenticação bem-sucedida
                    // Você pode adicionar lógica para criar uma sessão de usuário ou definir um cookie de autenticação aqui

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credenciais inválidas");
                }
            }

            // Se a autenticação falhar ou se o modelo não for válido, retorne a mesma página de login com erros
            return View(model);
        }

        public IActionResult Ranking()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
