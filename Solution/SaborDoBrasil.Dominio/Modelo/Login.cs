using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Login : EntidadeBase
    {
        public Usuario Usuario { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }
    }
}
