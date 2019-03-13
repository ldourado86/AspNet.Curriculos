using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNet.Curriculos.Modelos
{
    public class Candidato
    {
        public int Id { get; set; }
        [Required][StringLength(30)]
        public String Nome { get; set; }
        [Required][Display(Name="Endereço",Prompt ="Digite o endereço")]
        public String Endereco { get; set; }
        [Required]
        public String Email { get; set; }
        public String Telefone { get; set; }
        [Required]
        public String Objetivo { get; set; }
        public IList<Experiencia> Experiencias { get; set; }
        public IList<Formacao> Formacoes { get; set; }
        public IList<Habilidade> Habilidades { get; set; }
        public byte[] Foto { get; set; }
    }
}
