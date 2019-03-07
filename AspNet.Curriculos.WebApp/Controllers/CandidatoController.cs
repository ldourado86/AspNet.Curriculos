using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet.Curriculos.Dados;
using AspNet.Curriculos.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.Curriculos.WebApp.Controllers
{
    public class CandidatoController : Controller
    {
        private CandidatoDAO dao;

        public CandidatoController(CandidatoDAO dao)
        {
            this.dao = dao;
        }

        public IActionResult Index()
        {
            IEnumerable<Candidato> lista = dao.ListarCandidatos();
            return View(lista);
        }

        public IActionResult Detalhes(int id)
        {
            Candidato candidato = dao.BuscaPorId(id);
            return View(candidato);
        }

        [HttpPost]
        public IActionResult Incluir(Candidato candidato)
        {
            if (ModelState.IsValid)
            {
                dao.IncluirCandidato(candidato);
                return RedirectToAction("Index");
            }
            return View(candidato);
        }

        [HttpGet]
        public IActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar(Candidato candidato)
        {
            if (ModelState.IsValid)
            {
                dao.AtualizaCandidato(candidato);
                return RedirectToAction("Index");
            }
            return View(candidato);
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Candidato candidato = dao.BuscaPorId(id);
            if (candidato!=null)
            {
                return View(candidato);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            Candidato candidato = dao.BuscaPorId(id);
            if (candidato!=null)
            {
                dao.ExcluirCandidato(candidato);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}