using System;
using System.Collections.Generic;

namespace AspNet.Curriculos.Modelos
{
    public class Candidato
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Objetivo { get; set; }
        public IList<Experiencia> Experiencias { get; set; }

    }
}
