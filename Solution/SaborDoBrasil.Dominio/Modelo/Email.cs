using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Email
    {
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }
    }
}
