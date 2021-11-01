using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public class ReceitaRepositorio
    {
        private static List<Receita> db;

        public ReceitaRepositorio()
        {
            db = new List<Receita>();
        }


        public void Cadastrar(Receita receita)
        {
            db.Add(receita);
        }

        public List<Receita> BuscarTodos()
        {
            return db;
        }

        public Receita BuscarPorId(string id)
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

        public Receita Update(string id, Receita receita) 
        {
            var result = db.FirstOrDefault(x => x.Id == id);
            if (result is null)
            {
                return null;
            }
            result = receita;
            return result;
        }
    }
}
