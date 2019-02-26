using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet.Curriculos.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.Curriculos.WebApp.Controllers
{
    public class CandidatoController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes(int Id)
        {
            Candidato candidato = new Candidato();
            candidato.Nome = "Rafael";
            candidato.Email = "g.fael@yahoo.com";
            candidato.Endereco = "Meier";

            return View(candidato);
        }

    }
}