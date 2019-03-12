using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNet.Curriculos.Modelos
{
    public class Experiencia
    {
        public int Id { get; set; }
        [Required]
        public String Empresa { get; set; }
        [Required]
        public String Cargo { get; set; }
        [Required]
        public String Descricao { get; set; }

        public int CandidatoId { get; set; }

    }

}
