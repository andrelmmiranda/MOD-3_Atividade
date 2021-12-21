using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViagemTour.Models;

namespace ViagemTour.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult MensagemContatos()
        {
            string stringQuery = "SELECT * FROM Contato";

            List<Contato> dados = new AppQueries().Listar(stringQuery);

            dados.Reverse();

            ViewBag.dados = dados;

            return View();
        }

        public IActionResult Index()
        {
            string stringQuery = "SELECT * FROM Promocao";

            List<Promocao> data = new AppQueries().ListarPromocao(stringQuery);

            data.Reverse();

            ViewBag.dados = data;

            return View();
        }

        public IActionResult GerenciadorPromocao()
        {
            string stringQuery = "SELECT * FROM Promocao";

            List<Promocao> data = new AppQueries().ListarPromocao(stringQuery);

            data.Reverse();

            ViewBag.dados = data;

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Promocao promocao)
        {
            AppQueries query = new AppQueries();

            string stringQuery = string.Format("INSERT INTO Promocao (Local, QuantidadeDeDias, Hospedagem, CafeDaManha, PassagemAerea, Preco) VALUES ('{0}', {1}, '{2}', '{3}', '{4}', {5})", promocao.Local, promocao.QuantidadeDias, promocao.Hospedagem, promocao.CafeDaManha, promocao.PassagemAerea, promocao.Preco);

            query.Insert(stringQuery);

            return RedirectToAction("GerenciadorPromocao");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            AppQueries query = new AppQueries();

            Promocao promocao =  query.ListById(id);

            return View(promocao);
        }

        [HttpPost]
        public IActionResult Update(Promocao promocao)
        {
            AppQueries query = new AppQueries();

            string stringQuery = string.Format("UPDATE Promocao SET LOCAL='{0}', QTD_DIAS={1}, HOSPEDAGEM='{2}', CAFE_MANHA='{3}', PASSAGEM_AEREA='{4}', PRECO={5} WHERE Id={6}", promocao.Local, promocao.QuantidadeDias, promocao.Hospedagem, promocao.CafeDaManha, promocao.PassagemAerea, promocao.Preco, promocao.Id);

            query.Update(stringQuery);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            AppQueries query = new AppQueries();

            Promocao promocao = query.ListById(id);

            return View(promocao);
        }

        [HttpPost]
        public IActionResult Delete(Promocao promocao)
        {
            AppQueries query = new AppQueries();

            string stringQuery = string.Format("DELETE FROM Promocao WHERE Id={0}", promocao.Id);

            query.Delete(stringQuery);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteContato(int id)
        {
            AppQueries query = new AppQueries();

            Contato contato = query.ListByIdContato(id);

            return View(contato);
        }

        [HttpPost]
        public IActionResult DeleteContato(Contato contato)
        {
            AppQueries query = new AppQueries();

            string stringQuery = string.Format("DELETE FROM Contato WHERE Id={0}", contato.Id);

            query.Delete(stringQuery);

            return RedirectToAction("MensagemContatos");
        }
    }
}