using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNet.Curriculos.Dados.Migrations
{
    public partial class Fotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiencias_Candidatos_CandidatoId",
                table: "Experiencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Formacoes_Candidatos_CandidatoId",
                table: "Formacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Habilidades_Candidatos_CandidatoId",
                table: "Habilidades");

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "Habilidades",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "Formacoes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "Experiencias",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiencias_Candidatos_CandidatoId",
                table: "Experiencias",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Formacoes_Candidatos_CandidatoId",
                table: "Formacoes",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Habilidades_Candidatos_CandidatoId",
                table: "Habilidades",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiencias_Candidatos_CandidatoId",
                table: "Experiencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Formacoes_Candidatos_CandidatoId",
                table: "Formacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Habilidades_Candidatos_CandidatoId",
                table: "Habilidades");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Candidatos");

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "Habilidades",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "Formacoes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "Experiencias",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Experiencias_Candidatos_CandidatoId",
                table: "Experiencias",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formacoes_Candidatos_CandidatoId",
                table: "Formacoes",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Habilidades_Candidatos_CandidatoId",
                table: "Habilidades",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
