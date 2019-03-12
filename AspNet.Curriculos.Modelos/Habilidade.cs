using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNet.Curriculos.Modelos
{
    public class Habilidade
    {
        public int Id { get; set; }
        [Required]
        public String Skill { get; set; }
        public Candidato Candidato { get; set; }

        public int CandidatoId { get; set; }
    }
}
