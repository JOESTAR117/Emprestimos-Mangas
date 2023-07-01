using EmprestimosManga.Models;
using EmprestimosManga.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimosManga.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimosRepositories _emprestimosRepositories;

        public EmprestimoController(IEmprestimosRepositories emprestimosRepositories)
        {
            _emprestimosRepositories = emprestimosRepositories;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var emprestimos = _emprestimosRepositories.GetAll();

            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var emprestimos = _emprestimosRepositories.getById(id);

            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            var emprestimos = _emprestimosRepositories.getById(id);
            return View(emprestimos);
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _emprestimosRepositories.Add(emprestimos);

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _emprestimosRepositories.Update(emprestimos);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Deletar(EmprestimosModel emprestimos)
        {
            _emprestimosRepositories.Delete(emprestimos);
            return RedirectToAction("Index");
        }


    }
}
