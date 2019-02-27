using System;
using AspNet.Curriculos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AspNet.Curriculos.Dados
{
    public class CurriculosContext:DbContext
    {
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=DBCurriculos; trusted_connection=true");
            }
        }
    }
}
