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


        public Ingrediente Cadastrar(Ingrediente ingrediente, Perfil perfil)
        {
            if (Perfil.ESTOQUISTA == perfil || Perfil.COZINHEIRO == perfil) //--validação aqui mesmo? Ou na entidade
            {
                db.Add(ingrediente);
                return ingrediente;
            }

            return null;            
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
