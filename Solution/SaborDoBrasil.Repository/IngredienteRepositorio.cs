using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Repositorio
{
    public class IngredienteRepositorio
    {
        private static List<Ingrediente> data;

        public IngredienteRepositorio()
        {
            data = new List<Ingrediente>();
        }

        public void Cadastrar(Ingrediente ingrediente)
        {
            ingrediente.Id = Guid.NewGuid().ToString();
            data.Add(ingrediente);
        }

        public int QuantidadeIngredientes()
        {
            return data.Count;
        }
    }
}
