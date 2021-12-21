using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ViagemTour.Models;

namespace ViagemTour.Controllers
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

        public IActionResult Destino()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            string stringQuery = "SELECT * FROM Promocao";

            List<Promocao> data = new AppQueries().ListarPromocao(stringQuery);

            data.Reverse();

            ViewBag.dados = data;
                
            return View();
        }

        [HttpGet]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato(Contato contato)
        {
            AppQueries query = new AppQueries();

            string stringQuery = string.Format("INSERT INTO Contato (Nome, Email, Mensagem) VALUES('{0}', '{1}', '{2}')", contato.Nome, contato.Email, contato.Mensagem);

            query.Insert(stringQuery);

            return RedirectToAction("Contato");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

    
}
