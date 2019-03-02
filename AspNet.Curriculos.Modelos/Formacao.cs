using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNet.Curriculos.Modelos
{
    public class Formacao
    {
        public int Id { get; set; }
        [Required]
        public String Instituicao { get; set; }
        [Required]
        public String AreaDeEstudo { get; set; }
        [Required]
        public DateTime DataEntrada { get; set; }
        [Required]
        public DateTime DataSaida { get; set; }
       

    }
}
