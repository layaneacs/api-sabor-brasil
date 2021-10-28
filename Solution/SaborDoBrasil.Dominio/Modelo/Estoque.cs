using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Estoque: EntidadeBase
    {
        public Ingrediente Ingrediente { get; set; }
        public double QuantidadeAtual { get; set; }
        public double QuantidadeMaxima { get; set; }
        public double QuantidadeMinima { get; set; }

        public bool VerificaDesperdicio()
        {
            return QuantidadeAtual > QuantidadeMaxima;
        }
        public bool VerificaQuantidadeMinimaAtingida()
        {
            return QuantidadeAtual <= QuantidadeMinima;
        }



    }
}
