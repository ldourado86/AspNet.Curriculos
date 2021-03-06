﻿using System;
using AspNet.Curriculos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AspNet.Curriculos.Dados
{
    public class CurriculosContext:DbContext
    {
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }
        public DbSet<Formacao> Formacoes { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public CurriculosContext(DbContextOptions<CurriculosContext> options):base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=DBCurriculos; trusted_connection=true");
            }
        }
    }
}
