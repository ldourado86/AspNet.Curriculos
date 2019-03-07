using AspNet.Curriculos.Modelos;
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

        public Candidato BuscaPorId(int id)
        {
            return context.Candidatos
                .Include(c => c.Experiencias)
                .Include(c => c.Formacoes)
                .Include(c => c.Habilidades)
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Candidato> ListarCandidatos()
        {
            return context.Candidatos;
        }
    }
}
