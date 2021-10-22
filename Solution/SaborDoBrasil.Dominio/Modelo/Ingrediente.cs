﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Ingrediente: EntidadeBase
    {
        public string Nome { get; set; }
        public string Fornecedor { get; set; }
        public string Fabricante { get; set; }
        public DateTime Validade { get ; set; }


        public bool Valido()
        {
            return DateTime.Now < this.Validade;
        }

        
    }
}
