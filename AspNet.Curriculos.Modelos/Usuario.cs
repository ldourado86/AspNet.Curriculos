using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNet.Curriculos.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Senha { get; set; }
    }
}
