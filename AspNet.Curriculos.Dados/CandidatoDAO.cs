﻿using AspNet.Curriculos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNet.Curriculos.Dados
{
    public class CandidatoDAO
    {
        private CurriculosContext context;

        public CandidatoDAO(CurriculosContext context)
        {
            this.context = context;
        }

        public void IncluirCandidato(Candidato candidato)
        {
            context.Candidatos.Add(candidato);
            context.SaveChanges();
        }

        public Candidato BuscaPorId(int id)
        {
            return context.Candidatos
                .Include(c => c.Experiencias)
                .Include(c => c.Formacoes)
                .Include(c => c.Habilidades)
                .FirstOrDefault(c => c.Id == id);
        }

        public void AtualizaCandidato(Candidato candidato)
        {
            context.Candidatos.Update(candidato);
            context.SaveChanges();
        }

        public void ExcluirCandidato(Candidato candidato)
        {
            context.Candidatos.Remove(candidato);
            context.SaveChanges();
        } 

        public IEnumerable<Candidato> ListarCandidatos()
        {
            return context.Candidatos
                .Include(c => c.Habilidades)
                .Include(c => c.Experiencias)
                .Include(c => c.Formacoes);
        }

        public Experiencia BuscarExperiencia(int id)
        {
            return context.Experiencias              
                .FirstOrDefault(exp => exp.Id == id);
        }

        public void IncluirExperiencia(Experiencia experiencia)
        {
            context.Experiencias.Add(experiencia);
            context.SaveChanges();
        }

        public void ExcluirExperiencia(Experiencia experiencia)
        {
            context.Experiencias.Remove(experiencia);
            context.SaveChanges();
        }

        public Formacao BuscarFormacao(int id)
        {
            return context.Formacoes
                .FirstOrDefault(exp => exp.Id == id);
        }

        public void IncluirFormacao(Formacao formacao)
        {
            context.Formacoes.Add(formacao);
            context.SaveChanges();
        }

        public void ExcluirFormacao(Formacao formacao)
        {
            context.Formacoes.Remove(formacao);
            context.SaveChanges();
        }

        public Habilidade BuscarHabilidade(int id)
        {
            return context.Habilidades
                .FirstOrDefault(exp => exp.Id == id);
        }

        public void IncluirHabilidade(Habilidade habilidade)
        {
            context.Habilidades.Add(habilidade);
            context.SaveChanges();
        }

        public void ExcluirHabilidade(Habilidade habilidade)
        {
            context.Habilidades.Remove(habilidade);
            context.SaveChanges();
        }

    }
}
