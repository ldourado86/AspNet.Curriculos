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
            return View();
        }

        public IActionResult Detalhes(int id)
        {
            Candidato candidato1 = dao.BuscaPorId(id);
            return View(candidato1);
        }

    }
}