﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Prato : EntidadeBase
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}