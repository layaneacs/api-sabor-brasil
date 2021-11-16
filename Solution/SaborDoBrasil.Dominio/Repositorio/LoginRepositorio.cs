using SaborDoBrasil.Dominio.Modelo;
using SaborDoBrasil.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaborDoBrasil.Dominio.Repositorio
{
    public class LoginRepositorio
    {
        private static List<Login> db;
        private readonly UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();   
        
        public LoginRepositorio()
        {
            db = new List<Login>();
        }

        public Usuarios Logar(Login login) {

            var user = db.FirstOrDefault(x => x.User == login.User && x.Senha == login.Senha);

            if(user is null)
            {
                return null;
            }

            var usuario = usuarioRepositorio.BuscarPorId(user.Usuario.Id);
            return usuario;
        }
    }
}
