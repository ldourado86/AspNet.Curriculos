﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNet.Curriculos.Dados;
using AspNet.Curriculos.Modelos;
using AspNet.Curriculos.WebApp.Models;
using AspNet.Curriculos.WebApp.Utils;
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

        //Model Binding
        //  /Candidato/Index?pagina=1&tamanho=25&localizacao=Meier
        public IActionResult Index(
            [FromQuery] Paginacao paginacao,
            [FromQuery] FiltroCandidato filtro)
        {
            var listaPaginada = dao.ListarCandidatos()
                .AplicarFiltro(filtro)
                .ToListaPaginada<Candidato>(paginacao);
            return View(listaPaginada);
        }

        public IActionResult Detalhes(int id)
        {
            Candidato candidato = dao.BuscaPorId(id);
            return View(candidato);
        }

        [HttpPost]
        public IActionResult Incluir(CandidatoForm candidatoForm)
        {
            byte[] fotoAsByteArray = null;
            if (candidatoForm.Foto != null)
            {
                using (BinaryReader stream = new BinaryReader(candidatoForm.Foto.OpenReadStream()))
                {
                    fotoAsByteArray = stream.ReadBytes((int)candidatoForm.Foto.Length);
                }
            }
            var candidato = new Candidato
            {
                Nome = candidatoForm.Nome,
                Email = candidatoForm.Email,
                Telefone = candidatoForm.Telefone,
                Endereco = candidatoForm.Endereco,
                Objetivo = candidatoForm.Objetivo,
                Foto = fotoAsByteArray
            };
            //IFormFile
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
            if (candidato != null)
            {
                return View(candidato);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            Candidato candidato = dao.BuscaPorId(id);
            if (candidato != null)
            {
                dao.ExcluirCandidato(candidato);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult IncluirExperiencia(Experiencia experiencia)
        {
            if (ModelState.IsValid)
            {
                dao.IncluirExperiencia(experiencia);
                return RedirectToAction("Detalhes", new { id = experiencia.CandidatoId });
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult ExcluirExperiencia(int id)
        {
            Experiencia experiencia = dao.BuscarExperiencia(id);
            if (experiencia != null)
            {
                dao.ExcluirExperiencia(experiencia);
                return RedirectToAction("Detalhes", new { id = experiencia.CandidatoId });
            }
            return NotFound();
        }

        public IActionResult IncluirFormacao(Formacao formacao)
        {
            if (ModelState.IsValid)
            {
                dao.IncluirFormacao(formacao);
                return RedirectToAction("Detalhes", new { id = formacao.CandidatoId });
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult ExcluirFormacao(int id)
        {
            Formacao formacao = dao.BuscarFormacao(id);
            if (formacao != null)
            {
                dao.ExcluirFormacao(formacao);
                return RedirectToAction("Detalhes", new { id = formacao.CandidatoId });
            }
            return NotFound();
        }

        public IActionResult IncluirHabilidade(Habilidade habilidade)
        {
            if (ModelState.IsValid)
            {
                dao.IncluirHabilidade(habilidade);
                return RedirectToAction("Detalhes", new { id = habilidade.CandidatoId });
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult ExcluirHabilidade(int id)
        {
            Habilidade habilidade = dao.BuscarHabilidade(id);
            if (habilidade != null)
            {
                dao.ExcluirHabilidade(habilidade);
                return RedirectToAction("Detalhes", new { id = habilidade.CandidatoId });
            }
            return NotFound();
        }

        public IActionResult Foto(int id)
        {
            Candidato candidato = dao.BuscaPorId(id);
            if (candidato != null)
            {
                return File(candidato.Foto, "image/jpeg");
            }
            return NotFound();
        }

    }
}