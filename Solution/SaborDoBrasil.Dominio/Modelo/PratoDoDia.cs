using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class PratoDoDia : Prato
    {
        public DateTime Data { get; set; }
        public double Preco { get; set; }
        public int QuantidadePrato { get; set; }
    }
}
