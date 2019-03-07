using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet.Curriculos.Dados;
using AspNet.Curriculos.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.Curriculos.WebApp.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioDAO dao;

        public UsuariosController(UsuarioDAO dao)
        {
            this.dao = dao;
        }
        public IActionResult Index()
        {
            IEnumerable<Usuario> lista = dao.ListarUsuarios();
            return View(lista);
        }

        public IActionResult IncluirUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                dao.IncluirUsuario(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }
    }
}