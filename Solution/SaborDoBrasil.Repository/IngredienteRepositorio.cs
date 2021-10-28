using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public class IngredienteRepositorio
    {
        private static readonly List<Ingrediente> db = new List<Ingrediente>();

        public IngredienteRepositorio()
        {
        }


        public void Cadastrar(Ingrediente ingrediente, Perfil perfil)
        {
            if(perfil == Perfil.ESTOQUISTA || perfil == Perfil.COZINHEIRO)
            {
                db.Add(ingrediente);
            }            
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
