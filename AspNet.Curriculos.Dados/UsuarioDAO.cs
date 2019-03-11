using AspNet.Curriculos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNet.Curriculos.Dados
{
    public class UsuarioDAO
    {
        private CurriculosContext context;

        public UsuarioDAO(CurriculosContext context)
        {
            this.context = context;
        }

        public IEnumerable<Usuario> ListarUsuarios()
        {
            return context.Usuarios;
        }

        public void IncluirUsuario(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return context.Usuarios.FirstOrDefault(u => u.Id == id);
        }
        public void ExcluirUsuario(Usuario usuario)
        {
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
    }
}
