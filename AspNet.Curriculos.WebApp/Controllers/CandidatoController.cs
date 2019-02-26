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
            Candidato candidato1 = new Candidato();
            var lista = new List<Experiencia>();

            candidato1.Nome = "Rafael";
            candidato1.Email = "g.fael@yahoo.com";
            candidato1.Endereco = "Meier";
            candidato1.Experiencias = new List<Experiencia>();
            candidato1.Experiencias.Add(new Experiencia { Empresa = "Órama DTVM", Cargo = "Analista", Descricao = "trabalhei como analista financeiro." });
       

            return View(candidato1);
        }

    }
}