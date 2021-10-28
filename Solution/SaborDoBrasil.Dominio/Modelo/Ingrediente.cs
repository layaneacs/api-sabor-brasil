using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Ingrediente : EntidadeBase
    {
        public string Nome { get; set; }
        public Fabricante Fabricante { get; set; }
        public DateTime Validade { get ; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        public bool EstaValido()
        {
            return DateTime.Now < this.Validade;
        }

        
    }
}
