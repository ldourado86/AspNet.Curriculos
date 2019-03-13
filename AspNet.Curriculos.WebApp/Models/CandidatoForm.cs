using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNet.Curriculos.WebApp.Models
{
    public class CandidatoForm
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public String Nome { get; set; }
        [Required]
        [Display(Name = "Endereço", Prompt = "Digite o endereço")]
        public String Endereco { get; set; }
        [Required]
        public String Email { get; set; }
        public String Telefone { get; set; }
        [Required]
        public String Objetivo { get; set; }
        public IFormFile Foto { get; set; }
    }
}
