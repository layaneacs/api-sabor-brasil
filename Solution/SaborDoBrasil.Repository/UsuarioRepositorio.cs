using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public class UsuarioRepositorio
    {
        private static List<Usuario> db;

        public UsuarioRepositorio()
        {
            db = new List<Usuario>();
        }


        public void Cadastrar(Usuario usuarios)
        {
 
        }

        public List<Usuario> BuscarTodos()
        {
            return db;
        }

        public Usuario BuscarPorId(string id)
        {
            return db.FirstOrDefault(x => x.Id == id);
        }

        public bool Delete(string id)
        {
            var result = db.FirstOrDefault(x => x.Id == id);
            if(result is null)
            {
                return false;
            }

            db.Remove(result);
            return true;
        }

    }
}
