﻿// <auto-generated />
using System;
using AspNet.Curriculos.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNet.Curriculos.Dados.Migrations
{
    [DbContext(typeof(CurriculosContext))]
    [Migration("20190301235806_tableSkills")]
    partial class tableSkills
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNet.Curriculos.Modelos.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Endereco")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Objetivo")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("AspNet.Curriculos.Modelos.Experiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidatoId");

                    b.Property<string>("Cargo")
                        .IsRequired();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Empresa")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("AspNet.Curriculos.Modelos.Formacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaDeEstudo")
                        .IsRequired();

                    b.Property<int?>("CandidatoId");

                    b.Property<DateTime>("DataEntrada");

                    b.Property<DateTime>("DataSaida");

                    b.Property<string>("Instituicao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Formacoes");
                });

            modelBuilder.Entity("AspNet.Curriculos.Modelos.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidatoId");

                    b.Property<string>("Skill")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Habilidades");
                });

            modelBuilder.Entity("AspNet.Curriculos.Modelos.Experiencia", b =>
                {
                    b.HasOne("AspNet.Curriculos.Modelos.Candidato")
                        .WithMany("Experiencias")
                        .HasForeignKey("CandidatoId");
                });

            modelBuilder.Entity("AspNet.Curriculos.Modelos.Formacao", b =>
                {
                    b.HasOne("AspNet.Curriculos.Modelos.Candidato")
                        .WithMany("Formacoes")
                        .HasForeignKey("CandidatoId");
                });

            modelBuilder.Entity("AspNet.Curriculos.Modelos.Habilidade", b =>
                {
                    b.HasOne("AspNet.Curriculos.Modelos.Candidato")
                        .WithMany("Habilidades")
                        .HasForeignKey("CandidatoId");
                });
#pragma warning restore 612, 618
        }
    }
}
