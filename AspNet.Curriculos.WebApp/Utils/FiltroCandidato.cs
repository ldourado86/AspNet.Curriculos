using AspNet.Curriculos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Curriculos.WebApp.Utils
{

    public static class IEnumerableCandidatoExtensions 
    {
        public static IEnumerable<Candidato> AplicarFiltro(this IEnumerable<Candidato> lista, FiltroCandidato filtro)
        {
            if (!string.IsNullOrWhiteSpace(filtro.Objetivo))
            {
                lista = lista.Where(c => c.Objetivo.Contains(filtro.Objetivo));
            }
            if (!string.IsNullOrWhiteSpace(filtro.Localizacao))
            {
                lista = lista.Where(c => c.Endereco.Contains(filtro.Localizacao));
            }
            if (!string.IsNullOrWhiteSpace(filtro.Habilidade))
            {
                lista = lista.Where(c => c.Habilidades.Any(h => h.Skill.Contains(filtro.Habilidade)));
            }
            return lista;
        }
    }

    public class FiltroCandidato
    {
        public string Localizacao { get; set; }
        public string Habilidade { get; set; }
        public string Objetivo { get; set; }
    }
}
