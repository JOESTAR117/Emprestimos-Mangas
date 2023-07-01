﻿using EmprestimosManga.Data;
using EmprestimosManga.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimosManga.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmprestimoController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _context.Emprestimos;

            return View(emprestimos);
        }
    }
}
