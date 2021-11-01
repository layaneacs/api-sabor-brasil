﻿using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public class EstoqueRepositorio
    {
        private static List<Estoque> db;

        public EstoqueRepositorio()
        {
            db = new List<Estoque>();
        }


        public Estoque Cadastrar(Estoque estoque, Perfil perfil)
        {
            if (Perfil.ESTOQUISTA == perfil) //--validação aqui mesmo? Ou na entidade
            {
                db.Add(estoque);
                return estoque;
            }
            return null;
        }

        public List<Estoque> BuscarTodos()
        {
            return db;
        }

        public Estoque BuscarPorId(string id)
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

        public Estoque Update(string id, Estoque estoque) 
        {
            var result = db.FirstOrDefault(x => x.Id == id);
            if (result is null)
            {
                return null;
            }

            result = estoque;
            return result;
        }
    }
}
