using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public class IngredienteRepositorio
    {
        private static List<Ingrediente> db;

        public IngredienteRepositorio()
        {
            db = new List<Ingrediente>();
        }


        public void Cadastrar(Ingrediente ingrediente)
        {
            db.Add(ingrediente);
        }

        public List<Ingrediente> BuscarTodos()
        {
            return db;
        }

        public Ingrediente BuscarPorId(string id)
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
