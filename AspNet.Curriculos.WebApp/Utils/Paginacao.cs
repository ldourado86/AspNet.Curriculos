using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Curriculos.WebApp.Utils
{
    public class Paginacao
    {
        public int Pagina { get; set; }
        public int Tamanho { get; set; }
    }

    //1200 candidatos, página 21 de tamanho 20 >> 60
    //850 produtos, página 1 de tamanho 50
    //900 usuários, página 48 de tamanho 50
    //
    public class PaginaInfo
    {
        public int PaginaAtual { get; }
        public int TamanhoPagina { get; }
        public int TotalItens { get; }

        public int PaginaAnterior => PaginaAtual - 1;
        //{
        //    get { return PaginaAtual - 1; }
        //}
        public int PaginaSeguinte => PaginaAtual + 1;
        public int TotalPaginas => (int)Math.Ceiling(TotalItens / (double)TamanhoPagina);
        public int ItensADescartar => TamanhoPagina * PaginaAnterior;
        

        public PaginaInfo(int total, int atual = 1, int tam = 25) //new PaginaInfo(1200);
        {
            TamanhoPagina = tam == 0 ? 25 : tam;
            PaginaAtual = atual==0 ? 1 : atual;
            //if (atual == 0)
            //{
            //    PaginaAtual = 1;
            //} else
            //{
            //    PaginaAtual = atual;
            //}
            TotalItens = total;
        }


    }

    //1 - classe estática
    //2 - método estático
    //3 - primeiro argumento do método PRECISA ser do tipo a ser extendido precedido por THIS
    public static class IEnumerableExtensions
    {
        public static ListaPaginada<T> ToListaPaginada<T>(this IEnumerable<T> lista, Paginacao paginacao)
        {
            var paginaInfo = new PaginaInfo(lista.ToList().Count(), paginacao.Pagina, paginacao.Tamanho);
            return new ListaPaginada<T>
            {
                Pagina = paginaInfo,
                Itens = lista
                    .Skip(paginaInfo.ItensADescartar)
                    .Take(paginaInfo.TamanhoPagina)
            };
        }
    }


    public class ListaPaginada<T>
    {
        public PaginaInfo Pagina { get; set; }
        public IEnumerable<T> Itens { get; set; }
    }
}
