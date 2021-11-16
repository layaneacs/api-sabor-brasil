using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public class UsuarioRepositorio
    {
        private static List<Usuarios> db;

        public UsuarioRepositorio()
        {
            db = new List<Usuarios>();
        }


        public Usuarios Cadastrar(Usuarios usuario)
        {

            db.Add(usuario);
            return usuario;

        }

        public List<Usuarios> BuscarTodos()
        {
            return db;
        }

        public Usuarios BuscarPorId(string id)
        {
            return db.FirstOrDefault(x => x.Id == id);
        }

        public bool Delete(string id)
        {
            var result = db.FirstOrDefault(x => x.Id == id);
            if (result is null)
            {
                return false;
            }

            db.Remove(result);
            return true;
        }

        public Usuarios Update(string id, Usuarios usuario)
        {
            var result = db.FirstOrDefault(x => x.Id == id);
            if (result is null)
            {
                return null;
            }

            result = usuario;
            return result;
        }

    }
}
