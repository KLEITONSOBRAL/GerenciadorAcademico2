using GerenciadorAcademico2.Services;
using GerenciadorAcademico2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorAcademico2.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly ProjetoService _service;

        public ProjetosController(ProjetoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var projetos = _service.ObterTodos();
            return View(projetos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(NovoProjetoViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            _service.Adicionar(vm);
            return RedirectToAction(nameof(Index));
        }
    }
}
