using System;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Ingrediente : EntidadeBase
    {
        public string Nome { get; set; }
        public Fabricante Fabricante { get; set; }
        public DateTime Validade { get ; set; }


        public Ingrediente()
        {

        }

        public bool EstaValido()
        {
            return DateTime.Now < Validade;
        }
    }
}
