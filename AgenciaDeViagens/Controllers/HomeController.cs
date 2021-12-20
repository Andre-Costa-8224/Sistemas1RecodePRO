using AgenciaDeViagens;
using MeuTeste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgenciaDeViagens.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Dados()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            _context.clientes.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Destino(Viagem viagem)
        {
            _context.viagens.Add(viagem);
            _context.SaveChanges();
            return RedirectToAction("Destino");
        }

    }
}
